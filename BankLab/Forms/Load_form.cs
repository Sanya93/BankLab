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
		this.BeginInvoke(new MethodInvoker(delegate{
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
}
}