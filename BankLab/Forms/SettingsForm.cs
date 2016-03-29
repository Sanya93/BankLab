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
public partial class SettingsForm : Form
{
	private BankLab Parent;
	private Form PreviousForm = null;

	public SettingsForm(BankLab parent)
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

	private void SettingsForm_Load(object sender, EventArgs e)
	{
		Binding bind = new Binding("BackColor",Parent.Settings,"ActiveColor");
		bind.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		ActiveColorBox.DataBindings.Add(bind);
		bind = new Binding("BackColor",Parent.Settings,"InActiveColor");
		bind.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		UnactiveColorBox.DataBindings.Add(bind);
		bind = new Binding("BackColor",Parent.Settings,"TitleColor");
		bind.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
		TitleColorBox.DataBindings.Add(bind);
		StartupSetting.DataBindings.Add("Checked", Parent.Settings, "Autorun");
		ShowSidebarSetting.DataBindings.Add("Checked", Parent.Settings, "ShowSideBar");
		title_label.DataBindings.Add("BackColor",Parent.Settings,"TitleColor");
		this.DataBindings.Add("BackColor",Parent.Settings,"ActiveColor");
	}

	
	private void ColorBox_Click(object sender, EventArgs e)
	{
		ColorDialog CDialog = new ColorDialog();
		DialogResult result = CDialog.ShowDialog();
		if (result == System.Windows.Forms.DialogResult.OK) {
			((PictureBox)sender).BackColor = CDialog.Color;
		}
	}

	private void SetDefaultSettings_Click(object sender, EventArgs e)
	{
		ActiveColorBox.BackColor = SystemColors.Control;
		UnactiveColorBox.BackColor = SystemColors.ControlDark;
		TitleColorBox.BackColor = Color.SteelBlue;
		StartupSetting.Checked = false;
		ShowSidebarSetting.Checked = false;
	}

	private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		Parent.Settings.WriteSettings();
	}
}
}
