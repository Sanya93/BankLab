using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Excel =  Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using BankLab.Components;
using Microsoft.Win32;

namespace BankLab
{
public partial class BankLab : Form 
{
	public Components.DataTable CurrentDataTable;
	public Components.Menu CurrentMenu;
	public Components.ProgressBar CurrentProgressBar;
	public Components.SideBar CurrentSideBar;
	public Components.StatusBar CurrentStatusBar;
	public Modules.current_database CurrentDataBase;
	public Components.MDIForms MDI;
	public Components.CoefficientTable CurrentCoefficientForm;
	private bool SizeFlag;

	public BankLab()
	{
		InitializeComponent();
		InitializeControlsAndModules();
		Program.I_LoadForm.BeginInvoke(new MethodInvoker(delegate 
		{
			Program.I_LoadForm.Close();
		}));
	}

	public Size GetMdiConteinerSize()
	{
		System.Drawing.Size tmp = this.Controls.Find("MDIConteiner", true)[0].Size;
		return new Size(tmp.Width-6,tmp.Height-6);
	}

	private void InitializeControlsAndModules()
	{
		CurrentDataTable = new Components.DataTable(this);
		CurrentMenu = new Components.Menu(this, main_menu);
		CurrentCoefficientForm = new CoefficientTable(this);
		CurrentMenu.CreateDynamicMenuItems(bl_res_styles.bl_helper.Knames,
										   формыКоэффициентовToolStripMenuItem, true,
										   false, CurrentCoefficientForm.CoefficientClickDelegate,
										   bl_res_styles.Resource1.stock_function_autopilot);
		CurrentProgressBar = new Components.ProgressBar(toolstrip_progressbar, this);
		CurrentSideBar = new Components.SideBar("Диспетчер таблиц:", sidebar_panel, sidebar_splitter, this);
		CurrentStatusBar = new Components.StatusBar(status_bar, toolstrip_label, this);
		CurrentDataBase = new Modules.current_database();
		MDI = new Components.MDIForms(this);
	}

	private void выходToolStripMenuItem_Click(object sender, 
														EventArgs e)
	{
		System.Windows.Forms.Application.Exit();
	}

	public string ShowOpenDialog(String Filter) 
	{
		OpenFileDialog OpenDialog = new OpenFileDialog();
		OpenDialog.Filter = Filter;
		OpenDialog.ShowDialog();
		return OpenDialog.FileName;
	}

	public string ShowSaveDialog(string Filter, string Caption, string Alert)
	{
		SaveFileDialog SaveDbDialog = new SaveFileDialog();
		SaveDbDialog.OverwritePrompt = false;
		SaveDbDialog.Filter = Filter;
		SaveDbDialog.FileOk += (s,ee) => 
		{
			if (File.Exists(((SaveFileDialog)s).FileName)) {
				DialogResult Result = MessageBox.Show(Caption,
													  Alert, 
													  MessageBoxButtons.YesNo,
													  MessageBoxIcon.Warning);
				if (Result == System.Windows.Forms.DialogResult.No) {
					ee.Cancel = true;
				}
			}
		};
		SaveDbDialog.ShowDialog();
		return SaveDbDialog.FileName;
	}

	private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MDI.TryShowMDIForm(typeof(year_form)) == 0) { 
			SaveCurrentChangesUntilExit();
			object[] Args = new object[2]; 
			Args[0] = this;
			Args[1] = true;
			year_form MDIIntervalForm = new year_form(null, true);
			MDI.ShowMDIForm(MDIIntervalForm, Args);
		}
	}

	/* Resize children forms location */
	private void BankLab_Resize(object sender, EventArgs e)
	{
		for (int i = this.MdiChildren.Count() - 1; i >= 0; i--) {
			if (this.MdiChildren[i].GetType() == typeof(OptimizationForm)) {
				if (!SizeFlag) {
					((OptimizationForm)this.MdiChildren[i]).GetGrid().Hide();
					this.MdiChildren[i].Size = GetMdiConteinerSize();
					SetCenterToMDIForms();
					((OptimizationForm)this.MdiChildren[i]).GetGrid().Show();
				}
			}
		}
		SetCenterToMDIForms();
	}

	public void SetCenterToMDIForms()
	{
		foreach (Form CurrentMdiForm in this.MdiChildren) {
			CurrentMdiForm.Location = new Point(
											(this.Width - sidebar_panel.Width - 24) / 2 -
											CurrentMdiForm.Width / 2,
											(this.Height - main_menu.Height -
											status_bar.Height - 44) / 2 -
											CurrentMdiForm.Height / 2);
		}
	}

	private void импортToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveCurrentChangesUntilExit();
		CurrentProgressBar.ShowProgressBar();
		ExcelFunctions.ImportExcelFile(this, CurrentDataTable.GetDataTable());
		CurrentProgressBar.HideProgressBar();
	}

	private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((((ToolStripMenuItem)sender).Text == "Сохранить как")&&(сохранитьToolStripMenuItem.Enabled)) {
			if (MDI.TryShowMDIForm(typeof(save_form)) == 0) { 
				save_form MdiSaveForm = new save_form(null, null);
				object[] Args = new object[2];
				Args[0] = this;
				Args[1] = CurrentDataTable.GetDataTable();
				MDI.ShowMDIForm(MdiSaveForm, Args);
			}
		}
		else {
			if (сохранитьToolStripMenuItem.Enabled) {
				if ((CurrentDataBase.GetTableName() == String.Empty)&&(CurrentDataBase.GetDatabasePath() == String.Empty)&&(CurrentDataBase.GetCurrentDataBase() == null)) {
					if (MDI.TryShowMDIForm(typeof(save_form)) == 0) {
						save_form MdiSaveForm = new save_form(null, null);
						object[] Args = new object[2];
						Args[0] = this;
						Args[1] = CurrentDataTable.GetDataTable();
						MDI.ShowMDIForm(MdiSaveForm, Args);
					}
				}
				else {
					CurrentDataBase.GetCurrentDataBase().UpdateTableData(CurrentDataBase.GetCurrentDataBase().GetDataSet(),CurrentDataBase.GetTableName());
				}
			}
		}
	}

	private void изменитьИнтервалToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (изменитьИнтервалToolStripMenuItem.Enabled) {
			year_form MDIIntervalForm = new year_form(null, true);
			object[] Args = new object[2];
			Args[0] = this;
			Args[1] = false;
			MDI.ShowMDIForm(MDIIntervalForm, Args);
		}
	}

	public void CloseCurrentTable()
	{
		закрытьToolStripMenuItem.PerformClick();
	}

	private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (закрытьToolStripMenuItem.Enabled) {
			try
			{
				/* Close current document */
				SaveCurrentChangesUntilExit();
				CurrentDataTable.CloseTable();
				this.Text = "BankLab";
				CurrentMenu.ChangeMenuItemsEnable(false);
				CurrentDataBase.DataBaseClearValue();
				CurrentCoefficientForm.SetCurrentCoefficientForm(null);
				foreach (Form MDIForm in this.MdiChildren) {
					MDIForm.Close();
				}
				CurrentSideBar.ClearSideBar();
			}
			catch (Exception ex) { }
		}
	}

	private void показатьСкрытьБоковуюПанельToolStripMenuItem_Click(
																object sender, 
																EventArgs e)
	{
		CurrentSideBar.StartFlowSideBar();
  		SizeFlag = true;
		BankLab_ResizeEnd(null, null);
	}

	private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MDI.TryShowMDIForm(typeof(open_form)) == 0) { 
			SaveCurrentChangesUntilExit();
			open_form OpenForm = new open_form(null, null);
			object[] Args = new object[2];
			Args[0] = this;
			Args[1] = CurrentDataTable.GetDataTable();
			MDI.ShowMDIForm(OpenForm, Args);
		}
	}

	private int SaveCurrentChangesUntilExit()
	{
		if (CurrentDataTable.TableHasChanges()) {
			DialogResult Result = MessageBox.Show("Сохранить изменения?",
												  "База данных изменена",
												  MessageBoxButtons.YesNo,
												  MessageBoxIcon.Question);
			if (Result == System.Windows.Forms.DialogResult.Yes) {
				сохранитьToolStripMenuItem.PerformClick();
				return 1;
			}
		}
		return 0;
	}

	private void BankLab_FormClosing(object sender, FormClosingEventArgs e)
	{
		SaveCurrentChangesUntilExit();
	}

	private void диспетчерБазыДанныхToolStripMenuItem_Click(object sender, EventArgs e)
	{
		DataBaseEditor CurrentDataBaseEditor = new DataBaseEditor(null);
		object[] Args = new object[1];
		Args[0] = this;
		MDI.ShowMDIForm(CurrentDataBaseEditor, Args);
	}

	public void SetMinimumSize(Size size)
	{
		this.MinimumSize = new Size(size.Width + sidebar_panel.Width + 24, size.Height + 44 + main_menu.Height + status_bar.Height);
		if (this.MinimumSize.Height < 400) {
			this.MinimumSize = new Size(size.Width + sidebar_panel.Width + 24, 400); 
		}
	}

	public Size CalculateTableSize(DataGridView currentTable)
	{
		Size TableSize = new Size();
		for (int i = 0; i < currentTable.Rows.Count; i++) {
			for (int j = 0; j < currentTable.Rows[i].Cells.Count; j++) {
				if (i == 0) {
					TableSize.Width += currentTable.Rows[i].Cells[j].Size.Width;
				}
				else {
					j = currentTable.Rows[i].Cells.Count;
				}
			}
			TableSize.Height += currentTable.Rows[i].Height;
		}
		if (currentTable.ColumnHeadersVisible) {
			TableSize.Height += currentTable.ColumnHeadersHeight;
		}
		return TableSize;
	}

	private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
	{

	}

	private void прогнозированиеToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MDI.TryShowMDIForm(typeof(forecast_form)) == 0) {
			forecast_form CurrentForecastForm = new forecast_form(null);
			object[] Params = new object[1];
			Params[0] = this;
			MDI.ShowMDIForm(CurrentForecastForm, Params);
		}
	}

	private void оптимизацияToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MDI.TryShowMDIForm(typeof(OptimizationForm)) == 0) {	
			OptimizationForm CurrentOptimizationForm = new OptimizationForm(null);
			object[] Params = new object[1];
			Params[0] = this;
			MDI.ShowMDIForm(CurrentOptimizationForm, Params);
		}
	}

	private void sidebar_splitter_SplitterMoved(object sender, SplitterEventArgs e)
	{
		SizeFlag = true;
		BankLab_ResizeEnd(null, null);
		SetMinimumSize(MDI.GetCurrentVisibleForm().Size);
		SetCenterToMDIForms();
	}

	private void BankLab_ResizeEnd(object sender, EventArgs e)
	{
		if (SizeFlag) {
			for (int i = this.MdiChildren.Count() - 1; i >= 0; i--) {
				if (this.MdiChildren[i].GetType() == typeof(OptimizationForm)) {
					((OptimizationForm)this.MdiChildren[i]).GetGrid().Hide();
					this.MdiChildren[i].Size = GetMdiConteinerSize();
					SetCenterToMDIForms();
					((OptimizationForm)this.MdiChildren[i]).GetGrid().Show();
				}	
			}
			SizeFlag = false;
		}
	}

	private void BankLab_ResizeBegin(object sender, EventArgs e)
	{
		SizeFlag = true;
	}

	private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((CurrentDataTable.GetDataTable().SelectedCells.Count > 0 )&&(CurrentDataTable.GetDataTable().Visible)) {
			for (int i = 0; i < CurrentDataTable.GetDataTable().SelectedCells.Count; i++) {
				if (CurrentDataTable.GetDataTable().SelectedCells[i].ColumnIndex > 0) { 
					CurrentDataTable.GetDataTable().SelectedCells[i].Value = string.Empty;
				}
			}
		}
	}

	private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((CurrentDataTable.GetDataTable().SelectedCells.Count > 0 )&&(CurrentDataTable.GetDataTable().Visible)) {
			Clipboard.SetText(CurrentDataTable.GetDataTable().SelectedCells[0].Value.ToString());
		}
	}

	private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((CurrentDataTable.GetDataTable().SelectedCells.Count > 0 )&&(CurrentDataTable.GetDataTable().Visible)) {
				if (CurrentDataTable.GetDataTable().SelectedCells[0].ColumnIndex > 0) { 
					CurrentDataTable.GetDataTable().SelectedCells[0].Value = Clipboard.GetText();
				}
		}
	}

	private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if ((CurrentDataTable.GetDataTable().SelectedCells.Count > 0 )&&(CurrentDataTable.GetDataTable().Visible)) {
			if (CurrentDataTable.GetDataTable().SelectedCells[0].ColumnIndex > 0) { 
				Clipboard.SetText(CurrentDataTable.GetDataTable().SelectedCells[0].Value.ToString());
				CurrentDataTable.GetDataTable().SelectedCells[0].Value = string.Empty;
		   }
		}
	}

	private void обАвторахToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MDI.TryShowMDIForm(typeof(AuthorsForm)) == 0) {
			AuthorsForm CurrentAuthorsForm = new AuthorsForm(null);
			object[] Params = new object[1];
			Params[0] = this;
			MDI.ShowMDIForm(CurrentAuthorsForm, Params);
		}

	}

	private void настройкиПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
	{	
		if (MDI.TryShowMDIForm(typeof(SettingsForm)) == 0) {
			SettingsForm CurrentSettingsForm = new SettingsForm(null);
			object[] Params = new object[1];
			Params[0] = this;
			MDI.ShowMDIForm(CurrentSettingsForm, Params);
		}
	}
}
}