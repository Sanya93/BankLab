using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLab
{
public partial class save_form : Form
{
	private BankLab Parent;
	private DataGridView DataTable;

	public save_form(BankLab parent, DataGridView datatable)
	{
		InitializeComponent();
		Parent = parent;
		DataTable = datatable;
		ShowCurrentTableName();
	}

	private void ShowCurrentTableName()
	{
		if (Parent != null) {
		name_edit.Text = Parent.CurrentDataBase.GetTableName();
		}
	}
	private void cancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void SaveDataBase(string Value)
	{
		if(Value!=string.Empty)
		{
			string Filter = "Файлы Access (*.accdb)|*.accdb";
			string Caption = "База данных может быть не пуста!";
			string Alert = "Вы хотите записать таблицу в существующую базу данных?";
			string FileName = Parent.ShowSaveDialog(Filter, Caption, Alert);
			if (FileName != String.Empty) {
				if (!File.Exists(FileName)) {
					DBBankLabFunctions.CreateDataBase(FileName);
				}
				DBBankLabFunctions DataBaseFunction = new DBBankLabFunctions(FileName, this);
				int result = DataBaseFunction.SaveTable(name_edit.Text, DataTable);
				if (result == 1) {
					Parent.CurrentDataBase.SetTableName(name_edit.Text);
					Parent.CurrentDataBase.SetDataBasePath(FileName);
					Parent.CurrentDataBase.SetCurrentDataBase(DataBaseFunction);
					Parent.Text += " - " + FileName;
				}
				if (result == -1) {
					this.FormClosing -= CloseSaveFormDelegate;
				}
				this.Close();
			}
		}
		else
		{
			MessageBox.Show("Имя не может быть пустым",
							 "Ошибка имени файла", 
							  MessageBoxButtons.OK, 
							  MessageBoxIcon.Error);
		}
	}

	private void ok_Click(object sender, EventArgs e)
	{
		SaveDataBase(name_edit.Text);
	}

	private void name_edit_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) {
			this.Focus();
			this.ok.PerformClick();
		}
		if (e.KeyCode == Keys.Escape) {
			this.Close();
		}
	}
	
	private void CloseSaveFormDelegate(object sender, CancelEventArgs e)
	{
		Parent.CurrentMenu.SetMainMenuEnableOn();
		Parent.CurrentDataTable.SetTableVisibleOn();
	}

	private void save_form_Load(object sender, EventArgs e) 
	{
		this.FormClosing += CloseSaveFormDelegate;
	}
}
}