using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BankLab;

namespace BankLab
{
public partial class year_form : Form
{
	private bool Create = true;
	private BankLab Parent;
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

	public year_form(BankLab parent, bool create)
	{
		InitializeComponent();
		Create = create;
		Parent = parent;
		this.start_year_edit.KeyDown += DelegateButtonsDown;
		this.end_year_edit.KeyDown += DelegateButtonsDown;
	}

	private void DataTableInit(int StartYear, int EndYear) 
	{
		if (StartYear <= EndYear) {
			if (Create) {
				Parent.CurrentDataTable.ReinitializeDataTable(StartYear, EndYear);
			}
			else {
				Parent.CurrentDataTable.TableChangeInterval(StartYear, EndYear);
			}
			this.Close();
		}
		else {
			MessageBox.Show("Неверный интервал",
							 "Возникла ошибка",
							  MessageBoxButtons.OK,
							  MessageBoxIcon.Error,
							  MessageBoxDefaultButton.Button1,
							  MessageBoxOptions.ServiceNotification);
		}
	}

	private void ok_Click(object sender, EventArgs e)
	{
		try
		{
			int StartYear = Convert.ToInt32(start_year_edit.Text);
			int EndYear = Convert.ToInt32(end_year_edit.Text);
			DataTableInit(StartYear, EndYear);
		}
		catch(FormatException ex) {
			MessageBox.Show("Неверно введены данные",
							"Ошибка ввода",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
		}
	}

	private void cancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void year_form_KeyUp(object sender, KeyEventArgs e)
	{
		if(e.KeyCode == Keys.Escape)
		{
			this.Close();
		}
	}

	private void year_form_Load(object sender, EventArgs e) 
	{
		this.FormClosing += delegate
		{
			Parent.CurrentMenu.SetMainMenuEnableOn();
			Parent.CurrentDataTable.SetTableVisibleOn();
		};
	}
}
}
