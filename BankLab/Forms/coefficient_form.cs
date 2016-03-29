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
public partial class coefficient_form : Form
{
	private BankLab Parent = null;
	private Form PreviousForm = null;
	private int DefaultHeight;
	private int Index;
	private DataGridView Table;
	
	public coefficient_form(BankLab parent, int index)
	{
		InitializeComponent();
		this.DoubleBuffered = true;
		Parent = parent;
		if (Parent != null) { 
			PreviousForm = Parent.MDI.GetCurrentVisibleForm();
			if (PreviousForm != null) {
				PreviousForm.Hide();
			}
			else {
				Parent.CurrentDataTable.GetDataTable().Hide();
			}
			title_label.DataBindings.Add("BackColor",Parent.Settings,"TitleColor");
		}
		DefaultHeight = title_label.Height + sub_main_menu.Height + statusStrip1.Height;
		Index = index;
	}

	public void SetPreviousForm(Form value)
	{
		PreviousForm = value;
	}

	public Form GetPreviousForm()
	{
		return PreviousForm;
	}

	public int getDefaultHeight()
	{
		return DefaultHeight;
	}

	private void back_button_Click(object Sender, EventArgs e)
	{
		this.Hide();
		if (PreviousForm != null) {
			PreviousForm.Show();
		}
		else {
			Parent.CurrentDataTable.SetTableVisibleOn();
		}
	}

	private void корреляцияToolStripMenuItem_Click(object sender, EventArgs e)
	{
		object[] Args = new object[2];
		Args[0] = Parent;
		Args[1] = (DataGridView)this.Controls[this.Controls.IndexOfKey("Table")];
		ParamForm MDIParamForm = new ParamForm(null, null);
		Parent.MDI.ShowMDIForm(MDIParamForm, Args);
		this.Hide();
	}

	private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
	{
		back_button.PerformClick();
	}

	private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string Caption = "Файл существует!";
		string Alert = "Вы хотите продолжить сохранение?";
		String FileName = Parent.ShowSaveDialog("Файлы Excel (*.xlsx; *.xls)|*.xlsx;*.xls", Alert, Caption);
		if (FileName != string.Empty) {
			ExcelFunctions.SaveCoefficientTableToExcelFile((DataGridView)this.Controls[this.Controls.IndexOfKey("Table")], FileName);
		}
	}

	private void CloseCoefficientFormDelegate(object sender, CancelEventArgs e)
	{
		Parent.CurrentDataTable.SetTableVisibleOn();
	}

	public void AddTableAtForm()
	{
		if (Table != null) {
			Table.Dispose();
		}
		Table = Parent.CurrentCoefficientForm.CreateCoefficientTable(Index);
		Table.Parent = Parent.CurrentCoefficientForm.GetCurrentCoefficientForm();
		Table.BorderStyle = BorderStyle.None;
		ExcelFunctions.SetTablePropertyToCreateTamplate(Table);
		Table.ReadOnly = true;
		Table.ScrollBars = ScrollBars.None;
		Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().Size = new Size(
			Table.ColumnCount * Table.Columns[0].Width,
			Table.ColumnHeadersHeight + Table.RowCount * Table.Rows[0].Height + DefaultHeight);
		Parent.SetMinimumSize(Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().Size);
		Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().title_label.Text = bl_res_styles.bl_helper.Knames[Index];
		Parent.SetCenterToMDIForms();
	}

	public int GetIndex()
	{
		return Index;
	}

	public void SetIndex(int I)
	{
		Index=  I;
	}

	private void CoefficientForm_Load(object sender, EventArgs e)
	{
		Parent.CurrentCoefficientForm.SetCurrentCoefficientForm(this);
		AddTableAtForm();
		this.FormClosing += CloseCoefficientFormDelegate;
	}

}
}