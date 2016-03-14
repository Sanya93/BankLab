using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace BankLab
{
public partial class OptimizationForm : Form
{
	/* visual elements */
	private TextBox[] TargetEdit;
	private ComboBox TargetBox;

	/* global var */
	private string[] FunctionNames  ={"Прибыль", "Привлеченные средства", "Интегрированный коэффициент"};
	private string[] Prefixes = {"profit_","fund_","integrate_"};
	private DBBankLabFunctions CurrentDataBase = null;
	private DBBankLabFunctions DBFunc;
	private int CurrentFunctionIndex;
	private bool TableEdited;
	private ResFile DbFile;
	private BankLab Parent;
	private Form PreviousForm = null;

	public OptimizationForm(BankLab parent)
	{
		InitializeComponent();
		Parent = parent;
		if (Parent != null) { 
			PreviousForm = Parent.MDI.GetCurrentVisibleForm();
			if (PreviousForm != null) {
				PreviousForm.Hide();
			}
			else {
				Parent.CurrentDataTable.GetDataTable().Hide();
			}
		}
	}

	public void SetPreviousForm(Form value)
	{
		PreviousForm = value;
	}

	public Form GetPreviousForm()
	{
		return PreviousForm;
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		this.DoubleBuffered = true;
		DbFile = new ResFile(
			bl_res_doc.Resource1.optimization_db,
			AppDomain.CurrentDomain.BaseDirectory + "optimization_db.accdb");
		DbFile.CreateFile();
		//string path;
		OleDbConnection OleConnection = new OleDbConnection(
			"Provider=Microsoft.ACE.OLEDB.12.0;" + 
			"OLE DB Services = -2;" +
			"Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "optimization_db.accdb");
		DBFunc = new DBBankLabFunctions(OleConnection, Parent);
		this.Size = Parent.GetMdiConteinerSize();
		Parent.SetCenterToMDIForms();
	}

	public DataGridView GetGrid()
	{
		return Grid;
	}
	
	/* Visual content part */

	public void PrepareForCreateContent()
	{
		TargetPanel.Visible = false;
		TargetPanel.Controls.Clear();
	}

	public void CreateColumnHeader(int Index)
	{
		string TableName = Prefixes[Index] + "top_header";
		DBFunc.OpenTable(TableName);
		DataSet tmp_data = DBFunc.GetDataSet();
		Grid.Columns.Clear();
		for (int i = 0; i < tmp_data.Tables[TableName].Rows.Count; i++) {
			DataGridViewColumn Column;
			if (i != tmp_data.Tables[TableName].Rows.Count - 2) {
				Column = new DataGridViewTextBoxColumn();
				Column.CellTemplate = new DataGridViewCustomTextBoxCell();
				if (i < tmp_data.Tables[TableName].Rows.Count - 2) {
					Column.HeaderText = tmp_data.Tables[TableName].Rows[i][1].ToString() + Environment.NewLine + "X" + (i + 1).ToString();
				}
				else {
					Column.HeaderText = tmp_data.Tables[TableName].Rows[i][1].ToString();
				}
				Column.Name = "X" + i.ToString();
			}
			else {
				Column = new DataGridViewComboBoxColumn();
				Column.CellTemplate = new DataGridViewCustomComboBoxCell();
				((DataGridViewComboBoxColumn)Column).Items.AddRange(new string[] { "=", ">=", "<=" });
				Column.HeaderText = tmp_data.Tables[TableName].Rows[i][1].ToString();
			}
			Grid.Columns.Add(Column);
			Grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			Grid.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
		}
	}

	public void CreateRowHeader(int Index)
	{
		string TableName = Prefixes[Index] + "left_header";
		DBFunc.OpenTable(TableName);
		DataSet tmp_data = DBFunc.GetDataSet();
		for (int i = 0; i < tmp_data.Tables[TableName].Rows.Count - 1; i++) {
			DataGridViewRow Row = new DataGridViewRow();
			Row.Height = 30;
			DataGridViewRowHeaderCell Head = new DataGridViewRowHeaderCell();
			Head.Value = tmp_data.Tables[TableName].Rows[i][1].ToString();
			Row.HeaderCell = Head;
			Grid.Rows.Add(Row);
			if (Convert.ToInt32(tmp_data.Tables[TableName].Rows[i][2]) == 2) {
				DataGridViewRow RowCopy = (DataGridViewRow)Row.Clone();
				RowCopy.HeaderCell = null;
				Grid.Rows.Add(RowCopy);
			}
		}
	}

	public void CreateTargetFunctionLine(int Count)
	{
		TargetEdit = new TextBox[Count];
		for (int i = 0; i < Count - 1; i++) {
			TargetEdit[i] = new TextBox();
			TargetEdit[i].Parent = TargetPanel;
			TargetEdit[i].Width = 75;
			TargetEdit[i].Location = new Point(15 + i * 130, 10);
			Label x_i = new Label()
			{
				AutoSize = true,
				Parent = TargetPanel,
				Location = new Point(92 + i * 130, 14)
			};
			if (i == Count - 2) {
				x_i.Text = "X" + (i + 1).ToString() + ";            C=";
				TargetEdit[i + 1] = new TextBox()
				{
					Parent = TargetPanel,
					Width = 75,
					Location = new Point(x_i.Right + 3, 10)
				};
				TargetBox = new ComboBox()
				{
					Parent = TargetPanel,
					Location = new Point(TargetEdit[i + 1].Right + 10, 10)
				};
				TargetBox.Items.AddRange(new string[] { "max", "min" });
			}
			else {
				x_i.Text = "X" + (i + 1).ToString() + " + ";
			}
		}
	}

	public void SetTableProperties(DataGridView Table)
	{
		Table.ColumnHeadersHeight = 70;
		Table.RowHeadersWidth = 200;
		Table.AllowUserToAddRows = false;		
		Table.AllowUserToDeleteRows = false;
		Table.AllowUserToOrderColumns = false;
		Table.AllowUserToResizeColumns = false;
		Table.AllowUserToResizeRows = false;
	}

	/* Database part */

	public void CreateNewDataBase(string NewName)
	{
		ProgressLabel.Text = "Создание файла...";
		Microsoft.Office.Interop.Access.Application App = 
			new Microsoft.Office.Interop.Access.Application();
		string path = AppDomain.CurrentDomain.BaseDirectory;
		App.OpenCurrentDatabase(path+"optimization_db.accdb",false,"");
		DBBankLabFunctions.CreateDataBase(NewName);
		for (int i = 0; i < Prefixes.Length; i++) {
			App.DoCmd.CopyObject(
				NewName,
				Prefixes[i] + "data",
				Microsoft.Office.Interop.Access.AcObjectType.acTable,
				Prefixes[i]+"data");
		}
		App.CloseCurrentDatabase();
		App.Quit();
		CurrentDataBase = new DBBankLabFunctions(NewName,Parent);
		ProgressLabel.Text = String.Empty;
	}

	public void SaveData(int Index)
	{
		ProgressLabel.Text = "Сохранение...";
		CurrentDataBase.OpenTable(Prefixes[Index] + "data");
		DataSet data = CurrentDataBase.GetDataSet();
		for (int i = 0; i < Grid.ColumnCount; i++) {
			for (int j = 0; j < data.Tables[0].Rows.Count - 1; j++) {
				data.Tables[0].Rows[j][i + 1] = Grid[i, j].Value;
			}
		}
		for (int i = 0; i < TargetEdit.Length - 1; i++) {
			data.Tables[0].Rows[Grid.RowCount][i + 1] = TargetEdit[i].Text;
		}
		data.Tables[0].Rows[Grid.RowCount][TargetEdit.Length] = TargetBox.SelectedItem;
		CurrentDataBase.UpdateTableData(data, Prefixes[Index] + "data");
		ProgressLabel.Text = String.Empty;
	}	

	public void OpenData(int Index)
	{
		CreateContent(Index);
		CurrentDataBase.OpenTable(Prefixes[Index] + "data");
		DataSet data = CurrentDataBase.GetDataSet();
		for (int i = 0; i < Grid.ColumnCount; i++) {
			for (int j = 0; j < data.Tables[0].Rows.Count - 1; j++) {
				Grid[i,j].Value = data.Tables[0].Rows[j][i + 1];
			}
		}
		for (int i = 0; i < TargetEdit.Length - 1; i++) {
			TargetEdit[i].Text = data.Tables[0].Rows[Grid.RowCount][i + 1].ToString();
		}
		//what is C?
		//target_text[target_text.Length - 1].Text = data.Tables[0].Rows[Grid.RowCount][target_text.Length].ToString();
		TargetBox.SelectedItem = data.Tables[0].Rows[Grid.RowCount][TargetEdit.Length];
		TableEdited = false;
	}

	/* Excel part*/

	public Excel.Application GetApplicationWithTemplate(ref bool newFile,string fileName)
	{
		Excel.Application ExApp = new Excel.Application();
		ResFile template = new ResFile(
								bl_res_doc.Resource1.templates,
								AppDomain.CurrentDomain.BaseDirectory+"tmp.xlsx");
		if ((File.Exists(fileName)) && (fileName.IndexOf("test") >= 0)) {
			ResFile tmpFile = new ResFile(null,fileName);
			tmpFile.FreeFile();
		}
		if (File.Exists(fileName)) newFile = false;
		if (newFile) {
			ExApp.Workbooks.Add();
		}
		else {
			ExApp.Workbooks.Open(fileName);
		}
		template.CreateFile();
		ExApp.Workbooks.Open(template.FileName);
		ExApp.Workbooks[2].Worksheets[Prefixes[CurrentFunctionIndex]].Copy(ExApp.Workbooks[1].Worksheets[1]);
		ExApp.Workbooks[2].Close();
		template.FreeFile();
		return ExApp;
	}

	public void AddTestSheets(ref Excel.Application ExApp)
	{
		ResFile testFile = new ResFile(
								(byte[])bl_res_doc.Resource1.ResourceManager.GetObject(Prefixes[CurrentFunctionIndex]+"test"),
								AppDomain.CurrentDomain.BaseDirectory+"test.xlsx");
		testFile.CreateFile();
		ExApp.Workbooks.Open(testFile.FileName);
		for (int i = 0; i < 3; i++) {
			ExApp.Workbooks[2].Worksheets[i+1].Copy(ExApp.Workbooks[1].Worksheets[i+2]);
		}
		ExApp.Workbooks[2].Close(false);
		testFile.FreeFile();
	}

	/* Common functions */

	private void CreateContent(int Index)
	{
		ProgressLabel.Text = "Создание документа...";
		this.Refresh();
		PrepareForCreateContent();
		CreateColumnHeader(Index);
		CreateRowHeader(Index);
		CreateTargetFunctionLine(Grid.ColumnCount - 1);
		SetTableProperties(Grid);
		TargetPanel.Visible = true;
		ProgressLabel.Text = String.Empty;
		TargetFunc.Text = "Целевая функция: " + FunctionNames[Index];
		сохранитьToolStripMenuItem.Enabled = true;
		экспортToolStripMenuItem.Enabled = true;
		целеваяФункцияToolStripMenuItem.Enabled = true;
		TableEdited = false;
	}

	private void OpenDataBase()
	{
		string Filter = "Файлы Access (*.accdb)|*.accdb";
		String TablePath = Parent.ShowOpenDialog(Filter);
		if (TablePath != String.Empty) {
			CurrentDataBase = new DBBankLabFunctions(TablePath, Parent);
			List<string> Tables = CurrentDataBase.GetTableList();
			for (int i = 0; i < Prefixes.Length; i++) {
				if (Tables.IndexOf(Prefixes[i] + "data") == -1) {
					MessageBox.Show(
						"Выберите другой файл",
						"Ошибка структуры файла",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
					CurrentDataBase = null;
					return;
				}
			}
			String Pattern = "(\\w*.\\w*\\Z)";
			Match DBName = Regex.Match(TablePath, Pattern);
			title_label.Text ="Оптимизация - " + DBName.Value;
			CurrentFunctionIndex = 0;
			OpenData(0);
		}
	}

	private int SaveDataBase()
	{
		if (CurrentDataBase != null) {
			SaveData(CurrentFunctionIndex);
			TableEdited = false;
			return 1;
		}
		else {
			string Filter = "Файлы Access (*.accdb)|*.accdb";
			String TablePath = Parent.ShowSaveDialog(Filter,"Заменить файл?","Файл существует");
			if (TablePath != String.Empty) {
				ResFile tmp_file = new ResFile(null,TablePath);
				tmp_file.FreeFile();
				CreateNewDataBase(TablePath);
				String Pattern = "(\\w*.\\w*\\Z)";
				Match DBName = Regex.Match(TablePath, Pattern);
				title_label.Text ="Оптимизация - " + DBName.Value;
				CurrentDataBase = new DBBankLabFunctions(TablePath, Parent);
				SaveData(CurrentFunctionIndex);
				TableEdited = false;
				return 1;
			}
			else {
				return 0;
			}
		}
	}

	private void ExportDataToExcel(string fileName)
	{
		ProgressLabel.Text = "Создание шаблона таблицы....";
		bool newFile = true;
		Excel.Application ExApp = GetApplicationWithTemplate(ref newFile, fileName);
		ProgressLabel.Text = "Экпортирование данных....";
		for (int i = 0; i < Grid.RowCount; i++) {
			for (int j = 0; j < Grid.ColumnCount; j++) {
				bool offset = j >= Grid.ColumnCount - 2;
				ExApp.Workbooks[1].Worksheets[1].Cells[j + 2 + Convert.ToByte(offset)][i + 5].Value = Grid[j,i].Value;
			}
		}
		for (int i = 0; i < TargetEdit.Length - 1; i++) {
			ExApp.Workbooks[1].Worksheets[1].Cells[i + 2][Grid.RowCount + 5].Value = TargetEdit[i].Text;
		}
		ExApp.Workbooks[1].Worksheets[1].Cells[Grid.ColumnCount + 1][Grid.RowCount + 5].Value =
			TargetBox.SelectedItem;
		if (fileName.IndexOf("test") > 0) {
			AddTestSheets(ref ExApp);
		}
		ExApp.Workbooks[1].Worksheets[ExApp.Workbooks[1].Worksheets.Count].Delete();
		ExApp.Workbooks[1].Worksheets[1].Select();
		if (newFile) {
			ExApp.Workbooks[1].Close(true, fileName);
		}
		else {
			ExApp.Workbooks[1].Close(true);
		}
		ExApp.Quit();
		ProgressLabel.Text = String.Empty;
	}

	private int CheckChanges()
	{
		if (TableEdited) { 
			DialogResult result =  MessageBox.Show(
				"Сохранить изменения?",
				"Данные были изменены",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Exclamation);
			if (result == DialogResult.Yes) {
				return SaveDataBase();
			}
			if (result == DialogResult.No) {
				return 1;
			}
			if (result == DialogResult.Cancel) {
				return 0;
			}
		}
		return 1;
	}

	/* Event functions */	

	private void MenuTargetFunction_Click(object sender, EventArgs e)
	{
		if (CheckChanges() == 1) { 
			int Index = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
			CurrentFunctionIndex = Index;
			CreateContent(Index);
			if (CurrentDataBase != null) {
				 OpenData(Index);
			}
		}
	}

	private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (CheckChanges() == 1) { 
			CurrentDataBase = null;
			CurrentFunctionIndex = 0;
			CreateContent(0);
		}
	}

	private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
	{	
		if (CheckChanges() == 1) { 
			OpenDataBase();
		}
	}

	private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveDataBase();
	}

	private void экспортДанныхToolStripMenuItem_Click(object sender, EventArgs e)
	{
		SaveFileDialog SDialog = new SaveFileDialog();
		SDialog.Filter = "Файлы Excel (*.xlsx; *.xls)|*.xlsx;*.xls";
		DialogResult res = SDialog.ShowDialog();
		if (res == System.Windows.Forms.DialogResult.OK) {
			ExportDataToExcel(SDialog.FileName);
		}
	}

	private void back_button_Click(object sender, EventArgs e)
	{
		if (CheckChanges() == 1) { 
			if (PreviousForm != null) {
				PreviousForm.Show();
			}
			else {
				Parent.CurrentDataTable.SetTableVisibleOn();
			}
			this.Close();
		}
	}

	private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (CheckChanges() == 1) { 
			CurrentDataBase = null;
			Grid.Columns.Clear();
			TargetPanel.Controls.Clear();
			TargetFunc.Text = "Целевая функция: ";
			title_label.Text = "Оптимизация";
			целеваяФункцияToolStripMenuItem.Enabled = false;
			сохранитьToolStripMenuItem.Enabled = false;
			экспортToolStripMenuItem.Enabled = false;
		}
	}

	private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		TableEdited = true;
	}

	private void OptimizationForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//DBFunc.FreeDB();
		//GC.Collect();
		//DbFile.FreeFile();
	}
}
}