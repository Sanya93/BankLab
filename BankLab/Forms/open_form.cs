using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankLab
{
public partial class open_form : Form
{
	private BankLab Parent = null;
	private DataGridView DataTable = null;
	private String DataBasePath = String.Empty;
	private DBBankLabFunctions OpenningDataBase = null;

	public open_form(BankLab parent, DataGridView dataTable)
	{
		InitializeComponent();
		Parent = parent;
		DataTable = dataTable;
	}

	private void DelegateButtonsDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) {
			this.Focus();
			this.ok.PerformClick();
		}
		if (e.KeyCode == Keys.Escape) {
			this.Close();
		}
	}

	private void open_form_Load(object sender, EventArgs e)
	{
		this.FormClosing += CloseOpenFormDelegate;
		foreach (Control CurrentControl in this.Controls) {
			CurrentControl.KeyDown += DelegateButtonsDown;
		}
	}

	private void CloseOpenFormDelegate(object sender, CancelEventArgs e)
	{
		Parent.CurrentMenu.SetMainMenuEnableOn();
		Parent.CurrentDataTable.SetTableVisibleOn();
	}

	private void cancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void TryOpenDataBaseTable(string Name, string path)
	{
		OpenningDataBase.OpenTable(Name);

		if (OpenningDataBase.GetDataSet().Tables[Name].Rows.Count == 0) {
			DataGridView Table = Parent.CurrentDataTable.ReinitializeDataTable();
			ExcelFunctions.CreateTemplate(Parent, Table);
		}
		else {
			try {
				Parent.CurrentDataTable.ReinitializeDataTable(Convert.ToInt32(OpenningDataBase.GetDataSet().Tables[Name].Rows[0][0]), 
									Convert.ToInt32(OpenningDataBase.GetDataSet().Tables[Name].Rows[OpenningDataBase.GetDataSet().Tables[Name].Rows.Count - 1][0]));
				Parent.CurrentDataBase.SetTableName(Name);
				Parent.CurrentDataBase.SetCurrentDataBase(OpenningDataBase);
				Parent.CurrentDataBase.SetDataBasePath(path);
				Parent.CurrentDataTable.FillDataTable(OpenningDataBase.GetDataSet(), Name);
				Parent.CurrentDataTable.LinkDataTableToDataSet();
				Parent.Text = "BankLab - " + path;	}
			catch (FormatException ex) {
				MessageBox.Show("Невозможно открыть таблицу",
								"Неверный шаблон таблицы",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}
		
		this.Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		OpenningDataBase = null;
		string Filter = "Файлы Access (*.accdb)|*.accdb";
		String TablePath = Parent.ShowOpenDialog(Filter);
		if (TablePath != String.Empty) {
			String Pattern = "(\\w*.\\w*\\Z)";
			Match DBName = Regex.Match(TablePath, Pattern);
			FileNameEdit.Text = DBName.Value;
			DataBasePath = TablePath;
			OpenningDataBase = new DBBankLabFunctions(TablePath, this);
			List<string> TableList = OpenningDataBase.GetTableList();
			TableListBox.Items.AddRange((object[])TableList.ToArray());
			if (TableList.Count > 0) {
				TableListBox.SelectedIndex = 0;
			}
			else {
				MessageBox.Show("База данных пуста!",
								"Ошибка открытия",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
		}
	}

	private void ok_Click(object sender, EventArgs e)
	{
		if (TableListBox.Items.Count > 0) {
			if ((OpenningDataBase != null) &&
				(TableListBox.Items[TableListBox.SelectedIndex].ToString() != String.Empty)) {
				String TableName = (String)TableListBox.Items[TableListBox.SelectedIndex];
				TryOpenDataBaseTable(TableName, DataBasePath);
			}
		}
	}
}
} 