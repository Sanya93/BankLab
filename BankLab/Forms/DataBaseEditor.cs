using System;
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
public partial class DataBaseEditor : Form
{
	private BankLab Parent;
	private Form PreviousForm = null;

	public DataBaseEditor(BankLab parent)
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
		this.FormClosing += CloseDataBaseEditorFormDelegate;
	}

	public void SetPreviousForm(Form value)
	{
		PreviousForm = value;
	}

	public Form GetPreviousForm()
	{
		return PreviousForm;
	}

	private void back_btn_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	public void CheckBeforeShow()
	{
		if ((Parent != null) && (Parent.CurrentDataBase.GetDataBase().TableName == String.Empty)) {
			MessageBox.Show("База данных не открыта", 
							"Откройте базу данных",
							MessageBoxButtons.OK,
							MessageBoxIcon.Exclamation);
			CloseDataBaseEditorFormDelegate(null,null);
			this.Close();
		}
		else {
			this.Show();
		}
	}

	private void CloseDataBaseEditorFormDelegate(object sender, CancelEventArgs e)
	{
		if (PreviousForm != null) {
			PreviousForm.Show();
		}
		else {
			Parent.CurrentDataTable.SetTableVisibleOn();
		}
	}	

	private void DelegateButtonsDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape) {
			this.Close();
		}
	}
	
	private void FillTableList()
	{
		TableList.Items.Clear();
		RemoveTableComboBox.Items.Clear();
		List<string> NameList = Parent.CurrentDataBase.GetCurrentDataBase().GetTableList();
		int i = 1;
		foreach (string TableName in NameList) {
			TableList.Items.Add(" " + i.ToString() + ". " + TableName);
			i++;
		}
		RemoveTableComboBox.Items.AddRange((object[])NameList.ToArray());
		if (RemoveTableComboBox.Items.Count > 0) {
			RemoveTableComboBox.SelectedIndex = 0;
		}
	}

	private void DataBaseEditor_Load(object sender, EventArgs e)
	{
		foreach (Control CurrentControl in this.Controls) {
			CurrentControl.KeyDown += DelegateButtonsDown;
		}
		FillTableList();
	}

	private void RemoveButton_Click(object sender, EventArgs e)
	{
		if (RemoveTableComboBox.SelectedIndex > -1) {
			DialogResult Result = MessageBox.Show("Вы хотите удалить таблицу?", 
												  "Удаление таблицы", 
												   MessageBoxButtons.OKCancel, 
												   MessageBoxIcon.Question);
			if (Result == DialogResult.OK) {
				if (Parent.CurrentDataBase.GetTableName() == RemoveTableComboBox.SelectedItem.ToString()) {
					DialogResult CurrentTableResult = MessageBox.Show("Вы хотите удалить текущую таблицу?", 
																	  "Таблица открыта", 
																	  MessageBoxButtons.OKCancel,
																	  MessageBoxIcon.Question);
					if (CurrentTableResult == System.Windows.Forms.DialogResult.OK) {
						Parent.CurrentDataBase.GetCurrentDataBase().DeleteTable(RemoveTableComboBox.SelectedItem.ToString());
						Parent.CloseCurrentTable();
						this.Close();
					}
				}
				else {
					Parent.CurrentDataBase.GetCurrentDataBase().DeleteTable(RemoveTableComboBox.SelectedItem.ToString());
					FillTableList();
				}
			}
		}
	}

	private void AddButton_Click(object sender, EventArgs e)
	{
		if (TableNameEdit.Text != string.Empty) {
			if (Parent.CurrentDataBase.GetCurrentDataBase().CreateDataBaseTemplate(TableNameEdit.Text) == 0) {
				MessageBox.Show("Невозможно сохранить таблицу с таким именем", 
								"Ошибка сохранения",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}
			else {
				TableNameEdit.Text = string.Empty;
				FillTableList();	
			}
		}
	}

	
}
}