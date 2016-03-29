using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Drawing;

namespace BankLab
{
public static class RegistryOperation
{
	private static string[] SettingsKeys = {"ShowSideBar", "ActiveColor", "InActiveColor", "TitleColor"};
	private static string[] SettingsKeysValues = {"false", "-986896", "-6250336", "-12156236"};
	
	public static void AllowAccessVBOM()
	{
		RegistryKey hkcu = Registry.CurrentUser;
		hkcu = hkcu.OpenSubKey("Software\\Microsoft\\Office\\14.0\\Excel\\Security", true);
		hkcu.SetValue("AccessVBOM", 1, RegistryValueKind.DWord);
	}

	private static RegistryKey CreateRegistryFolder(RegistryKey RKey, string Name)
	{
		RKey.CreateSubKey(Name);
		return RKey.OpenSubKey(Name, true);
	}

	private static void CreateRegistryKey(RegistryKey RKey, string Name, string Value)
	{
		RKey.SetValue(Name, Value);
	}

	public static string[] GetSettingsArray()
	{
		string[] SettingsArray = new string[5];
		RegistryKey ProgramFolder = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BankLab").OpenSubKey("Settings");
		for (int i = 0; i < SettingsKeys.Length; i++) {
			SettingsArray[i] = ProgramFolder.GetValue(SettingsKeys[i]).ToString();
		}
		SettingsArray[4] = false.ToString();
		return SettingsArray;
	}

	public static void SetSettingsArray(string[] SettingsArray)
	{
		CheckProgramInRegistry();
		RegistryKey ProgramFolder = Registry.CurrentUser.OpenSubKey(@"Software\BankLab\Settings", true);
		for (int i = 0; i < SettingsKeys.Length; i++) {
			ProgramFolder.SetValue(SettingsKeys[i], SettingsArray[i]);
		}
		RegistryKey RunKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",  true);
		if (SettingsArray[4] == true.ToString()) {
			RunKey.SetValue("BankLab", "BankLab.exe");
		}
		else {
			//RunKey.DeleteValue("BankLab", false);
		}

	}

	public static void CheckProgramInRegistry()
	{
		RegistryKey ProgramFolder = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BankLab");
		if (ProgramFolder == null) {
			ProgramFolder = CreateRegistryFolder(Registry.CurrentUser.OpenSubKey("Software", true), "BankLab");
		}
		RegistryKey SettingsFolder = ProgramFolder.OpenSubKey("Settings");
		if (SettingsFolder == null) {
			SettingsFolder = CreateRegistryFolder(ProgramFolder, "Settings");
		}
		for (int i = 0; i < SettingsKeys.Length; i++) {
			if (SettingsFolder.GetValueNames().FirstOrDefault(w => { return w == SettingsKeys[i]; }) == null) {
				CreateRegistryKey(SettingsFolder, SettingsKeys[i], SettingsKeysValues[i]);
			}
		}	
	}
}
}