using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BankLab
{
public static class Program
{
	/* <summary> */
	/* The Application EntryPoint */
	/* </summary> */
	private static Thread LoadThread;
	public static ManualResetEvent LoadThreadPause = new ManualResetEvent(false);
	public static load_form I_LoadForm = new load_form(LoadThreadPause);

	private static void Th_LoadFormFunction(object sender)
	{
		Application.Run(I_LoadForm);
	}

	[STAThread]
	static void Main()
	{
		Application.EnableVisualStyles();
		/* Application.SetCompatibleTextRenderingDefault(false); */
		/* Preload Program Resource */
		LoadThread = new Thread(Th_LoadFormFunction);
		LoadThread.Start();
		LoadThreadPause.WaitOne();
		/* End of preload */
		/* Application starts after end of LoadThread functions */
		Application.Run(new BankLab());
	}
}
}