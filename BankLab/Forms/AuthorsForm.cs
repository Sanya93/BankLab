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
public partial class AuthorsForm : Form
{
	private BankLab Parent;
	private Form PreviousForm = null;

	public AuthorsForm(BankLab parent)
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
		title_label.DataBindings.Add("BackColor",Parent.Settings,"TitleColor");
		this.DataBindings.Add("BackColor",Parent.Settings,"ActiveColor");
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

	private void back_button_Click(object sender, EventArgs e)
	{
		if (PreviousForm != null) {
			PreviousForm.Show();
		}
		else {
			Parent.CurrentDataTable.SetTableVisibleOn();
		}
		this.Close();
	}

	private void toolTip1_Popup(object sender, PopupEventArgs e)
	{

	}

	private void label2_MouseEnter(object sender, EventArgs e)
	{
		toolTip1.Show("Подсказка", label2);
	}
}
}
