using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace BankLab
{
internal class ExcelFunctions
{
	/// <summary>
	/// Задает визуальные свойства таблицы
	/// </summary>
	/// <param name="Table">Исходная таблица</param>
	public static void SetTablePropertyToCreateTamplate(DataGridView Table) 
	{
		Table.AllowUserToOrderColumns = false;
		Table.AllowUserToResizeRows = false;
		Table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
		Table.AllowUserToAddRows = false;
		Table.AllowUserToDeleteRows = false;
		Table.AllowUserToResizeColumns = false;
		Table.BringToFront();
		Table.Dock = DockStyle.Fill;
		Table.EnableHeadersVisualStyles = false;
		Table.BorderStyle = BorderStyle.None;
		foreach (DataGridViewColumn tmp in Table.Columns) {
			tmp.SortMode = DataGridViewColumnSortMode.NotSortable;
		}
		Table.ColumnHeadersHeight = 70;
	}

	/// <summary>
	/// Создает общий шаблон для таблицы
	/// </summary>
	/// <param name="Parent">Родительская форма</param>
	/// <param name="Table">Исходная таблица</param>
	public static void CreateTemplate(BankLab Parent, DataGridView Table) 
	{
		Excel.Application ExcelApp;
		ExcelApp = new Excel.Application();
		ResFile Maket = new ResFile(bl_res_doc.Resource1.Maket, AppDomain.CurrentDomain.BaseDirectory + "~tmp.xlsx");
		Maket.CreateFile();
		Parent.CurrentProgressBar.SetProgressBarValue(35);
		ExcelApp.Workbooks.Open(Maket.FileName);
		Parent.CurrentProgressBar.SetProgressBarValue(50);
		Table.Columns.Add("Year", ExcelApp.Cells[1, 1].Value);
		Table.ColumnCount = 19;
		Parent.CurrentProgressBar.SetProgressBarValue(60);
		for (int i = 1; i <= 18; i++) {
			Table.Columns[i].Name = "X" + i.ToString();
			Table.Columns[i].HeaderText = ExcelApp.Cells[1, i + 1].Value;
			Table.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		}
		Parent.CurrentProgressBar.SetProgressBarValue(90);
		SetTablePropertyToCreateTamplate(Table);
		Parent.CurrentSideBar.AddTables();
		ExcelApp.Workbooks.Close();
		ExcelApp.Quit();
		Maket.FreeFile();
		Parent.CurrentMenu.ChangeMenuItemsEnable(true);
	}

	/// <summary>
	/// Импортирует Excell документ в таблицу
	/// </summary>
	/// <param name="Parent">Родительская форма</param>
	/// <param name="Table">Таблица назначения</param>
	/// <returns></returns>
	public static int ImportExcelFile(BankLab Parent, DataGridView Table) 
	{
		String FileName = Parent.ShowOpenDialog("Файлы Excel (*.xls; *.xlsx)|*.xls;*.xlsx");
		if (FileName == String.Empty) {
			Parent.CurrentProgressBar.HideProgressBar();
			return 0;
		}
		Excel.Application ExcelApp = new Excel.Application();
		ExcelApp.Workbooks.Open(FileName);
		Table.Visible = false;
		Parent.CurrentProgressBar.SetProgressBarValue(10);
		Table = Parent.CurrentDataTable.ReinitializeDataTable();
		ExcelFunctions.CreateTemplate(Parent, Table);
		for (int i = 0; i < ExcelApp.Sheets[1].UsedRange.Rows.Count - 1; i++) {
			Table.Rows.Add();
			for (int j = 1; j <= 18; j++) {
				Table.Rows[i].Cells[j].Value = ExcelApp.Cells[i + 2, j + 1].Value;
			}
		}
		Parent.CurrentProgressBar.SetProgressBarValue(90);
		Parent.CurrentDataTable.FillTableIntervalColumnByFirstYear(Convert.ToInt32(ExcelApp.Cells[2, 1].value));
		Table.Visible = true;
		ExcelApp.Workbooks.Close();
		ExcelApp.Quit();
		Parent.CurrentProgressBar.SetProgressBarValue(100);
		return 1;
	}
//экспорт в 
	public static int SaveCoefficientTableToExcelFile(DataGridView Table, String Path)
	{
		if ((Table != null)&&(Table.RowCount > 0))
		{
			if (File.Exists(Path)) {
				ResFile FileCommander = new ResFile(null, Path);
				FileCommander.FreeFile();
				FileCommander = new ResFile(null, null);
			}
			Excel.Application ExcelApp = new Excel.Application();
			ExcelApp.Workbooks.Add();
			for (int i = 0; i < Table.Rows[0].Cells.Count; i++) {
				ExcelApp.Cells[1, i + 1] = Table.Columns[i].HeaderText;
				ExcelApp.Workbooks[1].Worksheets[1].Columns[i + 1].ColumnWidth = Table.Columns[i].Width / 6;
			}
				ExcelApp.Workbooks[1].Worksheets[1].Rows[1].RowHeight = Table.ColumnHeadersHeight;
			for (int i = 0; i < Table.RowCount; i++) {
				for (int j = 0; j < Table.Rows[i].Cells.Count; j++) {
					ExcelApp.Cells[i + 2, j + 1] = Table.Rows[i].Cells[j].Value;
				}
			}
			ExcelApp.Columns.WrapText = true;
			ExcelApp.Workbooks[1].Close(true, Path);
			ExcelApp.Quit();
			return 1;
		}
		return 0;
	}

	private static Excel.Application GetExcelAppWithAddIn()
	{
		Excel.Application ExApp = new Excel.Application();
		foreach (Excel.AddIn addIn in ExApp.AddIns) {
			if (addIn.Name.Contains("ATPVBAEN")) {
				addIn.Installed = false;
				addIn.Installed = true;
			}
		}
		RegistryOperation.AllowAccessVBOM();
		ExApp.Workbooks.Add();
		return ExApp;
	}

	private static int ExportColumnsToExcel(Excel.Application exApp, bool[] SelectedColumns, BankLab Parent)
	{
		DataGridView Table = Parent.CurrentCoefficientForm.GetCoefficientTable();
		int CurColumn = 1;
		for (int i = 1; i < Table.ColumnCount; i++) {
			if (SelectedColumns[i - 1]) {
				exApp.Cells[1, CurColumn] = Table.Columns[i].HeaderText;
				for (int j = 1; j < Table.RowCount; j++) {
					exApp.Cells[j + 1, CurColumn].Value = Table.Rows[j].Cells[i].Value;
				}
				CurColumn++;
			}
		}
		return CurColumn;
	}

	private static void AddMacros(Excel.Application exApp, string macrosCode)
	{
		Microsoft.Vbe.Interop.VBComponent Module;
		Module = exApp.Workbooks[1].VBProject.VBComponents.Add(
					Microsoft.Vbe.Interop.vbext_ComponentType.vbext_ct_StdModule);
		Module.CodeModule.AddFromString(macrosCode);
	}

	private static DataGridView ReadResulFromExcel(Excel.Application exApp, bool HasHeader)
	{
		DataGridView ResTable = new DataGridView();
		ResTable.AutoSize = true;
		ResTable.RowHeadersVisible = false;
		ResTable.ColumnHeadersVisible = HasHeader;
		if (HasHeader) { 
			ResTable.Columns.Add("","");
			for (int i = 2; i <= exApp.Sheets[1].UsedRange.Columns.Count; i++) {
				ResTable.Columns.Add(i.ToString(), exApp.Cells[1, i].Value.ToString());
			}
		}
		else {
			ResTable.ColumnCount = exApp.Sheets[1].UsedRange.Columns.Count;
		}
		foreach (DataGridViewColumn col in ResTable.Columns) {
			col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			col.MinimumWidth=100;
		}
		int Offset = Convert.ToByte(!HasHeader); 
		for (int i = 2; i <= exApp.Sheets[1].UsedRange.Rows.Count + Offset; i++) {
			ResTable.Rows.Add();
			ResTable.Rows[i-2].Cells[0].Value = exApp.Cells[i - Offset,1].Value;
		}
		for (int i = 0; i < ResTable.RowCount; i++) {
			for (int j = 1; j < ResTable.ColumnCount; j++) {
				ResTable.Rows[i].Cells[j].Value = exApp.Cells[i + 2 - Offset, j + 1].Value;
			}
		}
		return ResTable;
	}

	public static DataGridView StartCorelation(bool[] SelectedColumns, BankLab Parent)
	{
			Excel.Application ExApp = GetExcelAppWithAddIn(); 
			int ColumnsCount = ExportColumnsToExcel(ExApp, SelectedColumns, Parent);
			string MacrosCode =
				"Sub cor()\r\n" +
				"Application.Run \"ATPVBAEN.XLAM!Mcorrel\", ActiveSheet.Range(\"$A$1:$" + 
				(char)((int)'A' + ColumnsCount - 2) + "$" + (Parent.CurrentCoefficientForm.GetCoefficientTable().RowCount + 1).ToString() + "\"), _\r\n" +
				"\"\", \"К\", True\r\n" +
				"End Sub\r\n";
			AddMacros(ExApp, MacrosCode);
			ExApp.Run("cor");
			DataGridView ResTable = ReadResulFromExcel(ExApp, true);
			ExApp.Workbooks[1].Close(false);
			ExApp.Workbooks.Close();
			ExApp.Quit();
			return ResTable;
	}

	public static DataGridView StartRegression(bool[] SelectedColumns, BankLab Parent)
	{
			Excel.Application ExApp = GetExcelAppWithAddIn(); 
			int ColumnsCount = ExportColumnsToExcel(ExApp, SelectedColumns, Parent);
			string MacrosCode =
				"Sub reg()\r\n" +
				"Application.Run \"ATPVBAEN.XLAM!Regress\", ActiveSheet.Range(\"$A$1:$A$" + Parent.CurrentCoefficientForm.GetCoefficientTable().RowCount.ToString() + "\"), _\r\n" +
				"ActiveSheet.Range(\"$B$1:$" + (char)((int)'A' + ColumnsCount - 2) + "$" + Parent.CurrentCoefficientForm.GetCoefficientTable().RowCount.ToString() + "\"), False, True, , \"\", False, False, False _\r\n" +
				", False, , False\r\n" +
				"End Sub\r\n";
			AddMacros(ExApp, MacrosCode);
			ExApp.Run("reg");
			DataGridView ResTable = ReadResulFromExcel(ExApp, false);
			ExApp.Workbooks[1].Close(false);
			ExApp.Workbooks.Close();
			ExApp.Quit();
			return ResTable;
	}
}
}