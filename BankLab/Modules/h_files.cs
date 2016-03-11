using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace BankLab 
{
class ResFile
{
	private byte[] pResource;
	public byte[] Resource
	{
		get { return pResource;}
		set { pResource = value;}
	}

	private string pFileName;
	public string FileName
	{
		get { return pFileName;}
		set { pFileName = value;}
	}

	public ResFile(byte[] resource,string fileName)
	{
		pResource = resource;
		pFileName = fileName;
	}

	~ResFile()
	{
		FreeFile();
	}

	public void CreateFile()
	{
		FreeFile();
		using (FileStream fs = File.Create(pFileName)) {
			fs.Write(pResource, 0, pResource.Length);
			fs.Close();
		}
		File.SetAttributes(pFileName, FileAttributes.Hidden);
	}

	public void KillProcByFile(string fileName)
	{
		Process tool = new Process();
		tool.StartInfo.FileName = "handle.exe";
		tool.StartInfo.Arguments = " -a "+'"'+ fileName+'"';
		tool.StartInfo.UseShellExecute = false;
		tool.StartInfo.RedirectStandardOutput = true;
		tool.Start();           
		tool.WaitForExit();
		string outputTool = tool.StandardOutput.ReadToEnd();
		string matchPattern = @"(?<=\s+pid:\s+)\b(\d+)\b(?=\s+)";
		foreach (Match match in Regex.Matches(outputTool, matchPattern)) {
			Process tmp_proc  = Process.GetProcessById(int.Parse(match.Value));
			tmp_proc.Kill();
			tmp_proc.WaitForExit();
		}
	}

	public void FreeFile()
	{
		if (File.Exists(pFileName)) { 
			try {
				File.Delete(pFileName);
			}
			catch (Exception ex) {
				KillProcByFile(pFileName);
				File.Delete(pFileName);
			}
		}
	}
}
}
