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
using Excel = Microsoft.Office.Interop.Excel;

namespace BankLab
{
public partial class forecast_form : Form
{
	private BankLab Parent = null;
	private float[,] Cache;
	private Form PreviousForm = null;

	public forecast_form(BankLab parent)
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

	public void ReadDataToCache()
	{
		ResFile tmp = new ResFile(
			bl_res_doc.Resource1.prognoz,
			AppDomain.CurrentDomain.BaseDirectory+"for.xlsx");
		tmp.CreateFile();
		Excel.Application ExApp = new Excel.Application();
		ExApp.Workbooks.Open(tmp.FileName);
		int RowCount = ExApp.Sheets[1].UsedRange.Rows.Count;
		int ColCount = ExApp.Sheets[1].UsedRange.Columns.Count;
		Cache = new float[RowCount,ColCount];
		for (int i=0;i<RowCount;i++){
			for (int j = 0; j < ColCount; j++) {
				Cache[i,j] = Convert.ToSingle(ExApp.Cells[i+1,j+1].Value);
			}
		}
		ExApp.Workbooks.Close();
		ExApp.Quit();
		tmp.FreeFile();
	}

	private void DelegateButtonsDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape) {
			this.Close();
		}
	}

	private void forecast_form_Load(object sender, EventArgs e)
	{
		this.FormClosing += CloseForecastFormDelegate;
		foreach (Control CurrentControl in this.Controls) {
			CurrentControl.KeyDown += DelegateButtonsDown;
		}
		target_coef.Items.AddRange(bl_res_styles.bl_helper.Knames);
		ReadDataToCache();
	}

	private void CloseForecastFormDelegate(object sender, CancelEventArgs e)
	{
		if (PreviousForm != null) {
			PreviousForm.Show();
		}
		else {
			Parent.CurrentDataTable.SetTableVisibleOn();
		}
	}

	private void cancel_Click(object sender, EventArgs e)
	{
		this.Close();
	}

	private void target_coef_SelectedIndexChanged(object sender, EventArgs e)
	{
		int Index = target_coef.SelectedIndex;
		constant_edit.Text = Cache[Index,0].ToString();
		table.Rows.Clear();
		for (int i = 1; i < Cache.GetUpperBound(0) / 2; i++) {
			if (Cache[Index, i * 2] != 0) {
			table.Rows.Add();
			table.Rows[i-1].Cells[0].Value = Cache[Index,i*2].ToString();
			table.Rows[i-1].Cells[1].Value = Cache[Index,i*2+1].ToString();
			}
		}
		result_edit.Text  = Cache[Index,1].ToString();
	}

}
} 