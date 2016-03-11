using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace BankLab
{
public static class RegistryOperation
{
	public static void AllowAccessVBOM()
	{
		RegistryKey hkcu = Registry.CurrentUser;
		hkcu = hkcu.OpenSubKey("Software\\Microsoft\\Office\\14.0\\Excel\\Security", true);
		hkcu.SetValue("AccessVBOM", 1, RegistryValueKind.DWord);
	}
}
}