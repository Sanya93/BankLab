using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BankLab.Components
{
public class Settings
{
	public bool Autorun { get; set; }
	public bool ShowSideBar { get; set; }
	public Color ActiveColor { get; set; }
	public Color InActiveColor { get; set; }
	public Color TitleColor { get; set; }

	public void ReadSettings()
	{
		string[] SettingsArray = RegistryOperation.GetSettingsArray();
		ShowSideBar = Convert.ToBoolean(SettingsArray[0]);
		ActiveColor = Color.FromArgb(Convert.ToInt32(SettingsArray[1]));
		InActiveColor = Color.FromArgb(Convert.ToInt32(SettingsArray[2]));
		TitleColor = Color.FromArgb(Convert.ToInt32(SettingsArray[3]));
		Autorun = Convert.ToBoolean(SettingsArray[4]);
	}

	public void WriteSettings()
	{
		string[] SettingsArray = new string[5];
		SettingsArray[0] = ShowSideBar.ToString();
		SettingsArray[1] = ActiveColor.ToArgb().ToString();
		SettingsArray[2] = InActiveColor.ToArgb().ToString();
		SettingsArray[3] = TitleColor.ToArgb().ToString();
		SettingsArray[4] =  Autorun.ToString();
		RegistryOperation.SetSettingsArray(SettingsArray);
	}
}
}
