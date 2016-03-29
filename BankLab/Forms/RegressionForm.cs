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
public partial class RegressionForm : Form
{
	private BankLab Parent;
	private ParamForm SelectColumnsForm;
	private DataGridView RegressionTable;
	private int DefaultHeight;

	public RegressionForm(BankLab parent, ParamForm selectColumnsForm, DataGridView regressionTable)
	{
		InitializeComponent();
		Parent = parent;
		SelectColumnsForm = selectColumnsForm;
		RegressionTable = regressionTable;
		DefaultHeight = title_label.Height + ButtonPanel.Height;
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		SelectColumnsForm.Show();
		this.Close();
	}

	private void RegressionForm_Load(object sender, EventArgs e)
	{
		title_label.Text += bl_res_styles.bl_helper.Knames[Parent.CurrentCoefficientForm.GetIndexOfCoefficientTable()];
		ExcelFunctions.SetTablePropertyToCreateTamplate(RegressionTable);
		RegressionTable.Parent = this;
		RegressionTable.BringToFront();
		RegressionTable.ScrollBars = ScrollBars.None;
		Size CurrentSize = Parent.CalculateTableSize(RegressionTable);
		CurrentSize.Height += DefaultHeight;
		this.Size = CurrentSize;
		Parent.SetMinimumSize(this.Size);
		Parent.SetCenterToMDIForms();
		title_label.DataBindings.Add("BackColor",Parent.Settings,"TitleColor");
		this.DataBindings.Add("BackColor",Parent.Settings,"ActiveColor");
	}

	private void StartButton_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Значения успешно сохранены!", 
						"Завершение операции", 
						MessageBoxButtons.OK, 
						MessageBoxIcon.Information);
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