using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel =  Microsoft.Office.Interop.Excel;
using Access = Microsoft.Office.Interop.Access;
using System.IO;

namespace BankLab
{
public partial class load_form : Form
{
	private Thread SupportThread;
	private ManualResetEvent _PauseThread;

	public load_form(ManualResetEvent PauseThread)
	{
		InitializeComponent();
		_PauseThread = PauseThread;
	}

	/* check all resources for application */
	private void Th_CheckResources(object sender)
	{
		this.BeginInvoke(new MethodInvoker(delegate
		{
			string[] FilesToCheckBeforeStart = { "bl_res_doc.dll", "bl_res_styles.dll", "handle.exe", "about.chm" };
			bool Flag = false;
			foreach (string tmp in FilesToCheckBeforeStart) {
				if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + tmp)) {
					MessageBox.Show("Отсутствует файл " + tmp, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Flag = true;
				}
			}
			if (Flag == true) {
				Program.IsLoadFalse = true;
			}
			try {
				Excel.Application CheckExcell = new Excel.Application();
				Access.Application CheckAccess = new Access.Application();
			}
			catch (Exception ex) {
				MessageBox.Show("Microsoft Office не установлен", "Ошибка программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			_PauseThread.Set();
		}));
	}

	private void load_form_Load(object sender, EventArgs e)
	{
		/* Set form's controls visual properties */
		title_label.Parent = pic_to_background;
		title_label.ForeColor = Color.Black;
		title_label.BackColor = Color.Transparent;
		init_proc_label.Parent = pic_to_background;
		init_proc_label.ForeColor = Color.Black;
		init_proc_label.BackColor = Color.Transparent;
		excel_ico.Parent = pic_to_background;
		excel_ico.ForeColor = Color.Black;
		excel_ico.BackColor = Color.Transparent;
		/* Start thraed to check application resources */
		SupportThread = new Thread(Th_CheckResources);
		SupportThread.Start();
	}

	private void pic_to_background_Click(object sender, EventArgs e)
	{

	}
}
}