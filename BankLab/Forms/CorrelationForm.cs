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
public partial class CorrelationForm : Form
{
	private BankLab Parent;
	private ParamForm SelectColumnsForm;
	private DataGridView CorrelationTable;
	private int DefaultHeight = 0;

	public CorrelationForm(BankLab parent, ParamForm selectColumnsForm, DataGridView correlationTable)
	{
		InitializeComponent();
		Parent = parent;
		SelectColumnsForm = selectColumnsForm;
		CorrelationTable = correlationTable;
		DefaultHeight = title_label.Height + ButtonPanel.Height;
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		SelectColumnsForm.Show();
		this.Close();
	}

	private void CorrelationForm_Load(object sender, EventArgs e)
	{
		title_label.Text += bl_res_styles.bl_helper.Knames[Parent.CurrentCoefficientForm.GetIndexOfCoefficientTable()];
		ExcelFunctions.SetTablePropertyToCreateTamplate(CorrelationTable);
		CorrelationTable.Parent = this;
		CorrelationTable.BringToFront();
		CorrelationTable.ScrollBars = ScrollBars.None;
		Size CurrentSize = Parent.CalculateTableSize(CorrelationTable);
		CurrentSize.Height += DefaultHeight;
		this.Size = CurrentSize;
		Parent.SetMinimumSize(this.Size);
		Parent.SetCenterToMDIForms();
	}

	private void StartButton_Click(object sender, EventArgs e)
	{
		DataGridView CorrelationTable = ExcelFunctions.StartRegression(SelectColumnsForm.GetSelectedColumns(), Parent);
		RegressionForm CurrentRegressionForm = new RegressionForm(null, null, null);
		object[] Params = new object[3];
		Params[0] = Parent;
		Params[1] = SelectColumnsForm;
		Params[2] = CorrelationTable;
		Parent.MDI.ShowMDIForm(CurrentRegressionForm, Params);
		this.Hide();
	}

	private void back_button_Click(object sender, EventArgs e)
	{
		Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().Hide();
		SelectColumnsForm.Close();
		Parent.CurrentMenu.SetMainMenuEnableOn();
		Parent.CurrentDataTable.SetTableVisibleOn();
		this.Close();
	}
}
}