using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BankLab.Components
{
public class DataTable
{
	private DataGridView DTable;
	private BankLab Parent;
	
	/// <summary>
	/// Получить экземпляр DTable
	/// </summary>
	/// <returns></returns>
	public DataGridView GetDataTable()
	{
		return DTable;
	}

	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="parentForm"></param>
	public DataTable(BankLab parentForm)
	{
		Parent = parentForm;
		DTable = new DataGridView();
		DTable.Visible = false;
	}

	/// <summary>
	/// Добавляет горизонтальный скролл по событию мыши к экземпляру таблицы
	/// </summary>
	/// <param name="Instance">Экземпляр таблицы</param>
	private void AddHorizontalScrollToDataTable(DataGridView Instance)
	{
		Instance.MouseWheel += (sender, e) =>
		{
			int offset = 0;
			int direction = Math.Sign(e.Delta);
			offset += Instance.HorizontalScrollingOffset - 20 * direction;
			if (offset < 0) {
				offset = 0;
			}
			Instance.HorizontalScrollingOffset = offset;
		};
	}
	
	/// <summary>
	/// Реинициализация таблицы
	/// </summary>
	/// <returns></returns>
	public DataGridView ReinitializeDataTable() 
	{
		DTable.Dispose();
		DTable = new DataGridView();
		DTable.Visible = false;
		AddHorizontalScrollToDataTable(DTable);
		Parent.Controls.Add(DTable);
		Parent.Text = "BankLab";
		return DTable;
	}

	/// <summary>
	/// Реинициализация таблицы
	/// </summary>
	/// <param name="StartYear">Начальный год интервала</param>
	/// <param name="EndYear">Конечный год интервала</param>
	public void ReinitializeDataTable(int StartYear, int EndYear) 
	{
		Parent.CurrentProgressBar.ShowProgressBar();
		DTable.Dispose();
		Parent.CurrentDataBase.DataBaseClearValue();
		DTable = new DataGridView();
		DTable.Visible = false;
		AddHorizontalScrollToDataTable(DTable);
		Parent.Controls.Add(DTable);
		Parent.CurrentProgressBar.SetProgressBarValue(25);
		ExcelFunctions.CreateTemplate(Parent, DTable);
		TableSetInterval(StartYear, EndYear);
		DTable.Visible = true;	
		Parent.CurrentProgressBar.HideProgressBar();
	}

	/// <summary>
	/// Задает временной интервал для таблицы
	/// </summary>
	/// <param name="StartYear">Начальный год интервала</param>
	/// <param name="EndYear">Конечный год интервала</param>
	/// <returns></returns>
	public int TableSetInterval(int StartYear, int EndYear)
	{
		for (int i = 0; i <= EndYear - StartYear; i++) {
			DTable.Rows.Add();
			DTable.Rows[i].Cells[0].Value = StartYear + i;
			DTable.Rows[i].Cells[0].ReadOnly = true;
		}
		return EndYear - StartYear + 1;
	}

	/// <summary>
	/// Изменяет временной интервал таблицы
	/// </summary>
	/// <param name="StartYear">Начальный год интервала</param>
	/// <param name="EndYear">Конечный год интревала</param>
	/// <returns></returns>
	public int TableChangeInterval(int StartYear, int EndYear)
	{
		if (DTable != null) {
			int Size = 0;
			bool IsDataBaseEmpty = true;
			if ((Parent.CurrentDataBase.GetTableName() != String.Empty) && (Parent.CurrentDataBase.GetCurrentDataBase() != null)) {
				IsDataBaseEmpty = false;
			}
			if (DTable.Rows.Count > (EndYear - StartYear + 1)) {
				DialogResult result = MessageBox.Show(
										  "Последние строки будут удалены!",
										  "Интервал меньше текущего",
										   MessageBoxButtons.OKCancel,
										   MessageBoxIcon.Warning);

				if (result == DialogResult.Cancel) return 0;
				Size = DTable.Rows.Count - (EndYear - StartYear + 1);
				for (int i = 0; i < Size; i++) {
					if (!IsDataBaseEmpty) {
						System.Data.DataTable Dset = Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[Parent.CurrentDataBase.GetTableName()];
						Dset.Rows[DTable.Rows.Count - 1].Delete();
					}
					DTable.Rows.Remove(DTable.Rows[DTable.Rows.Count - 1]);
				}
			}
			else {
				Size = (EndYear - StartYear + 1) - DTable.Rows.Count;
				for (int i = 0; i < Size; i++) {
					DTable.Rows.Add();
					if (!IsDataBaseEmpty) {
						System.Data.DataTable Dset = Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[Parent.CurrentDataBase.GetTableName()];
						Dset.Rows.Add(Dset.NewRow());
					}
				}
			}
			FillTableIntervalColumnByFirstYear(StartYear);
			if (!IsDataBaseEmpty) {
				Parent.CurrentDataBase.GetCurrentDataBase().UpdateTableData(Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet(), Parent.CurrentDataBase.GetTableName());
			}
			return Size;
		}
		return 0;
	}

	/// <summary>
	/// Заполняет интервал таблицы по начальному году
	/// </summary>
	/// <param name="StartYear"></param>
	/// <returns></returns>
	public int FillTableIntervalColumnByFirstYear(int StartYear) 
	{
		if (DTable.RowCount > 0) {
			for (int i = 0; i < DTable.Rows.Count; i++) {
				DTable.Rows[i].Cells[0].Value = StartYear + i;
				DTable.Rows[i].Cells[0].ReadOnly = true;
			}
			return DTable.RowCount;
		}
		return 0;
	}
	
	/// <summary>
	/// Делегат отслеживающий изменение каждой ячейки таблицы
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void LinkDataTableToDataSetDelegateFunction(object sender, DataGridViewCellEventArgs e)
	{
		Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[Parent.CurrentDataBase.GetTableName()].Rows[e.RowIndex][e.ColumnIndex] = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
	}

	/// <summary>
	/// Привязываем таблицу для изменения кэша базы данных
	/// </summary>
	public void LinkDataTableToDataSet()
	{
		DTable.CellValueChanged -= LinkDataTableToDataSetDelegateFunction;
		DTable.CellValueChanged += LinkDataTableToDataSetDelegateFunction;
	}

	/// <summary>
	/// Устанавливает значение visible=true для таблицы
	/// </summary>
	public void SetTableVisibleOn()
	{
		DTable.Visible = true;
	}

	/// <summary>
	/// Заполняет таблицу данными из базы
	/// </summary>
	/// <param name="Data">Текущий кэш данных</param>
	/// <param name="TableName">Имя таблицы</param>
	public void FillDataTable(DataSet Data, string TableName)
	{
		for (int i = 0; i < DTable.Rows.Count; i++) {
			for (int j = 1; j < DTable.Rows[i].Cells.Count; j++) {
				if (Data.Tables[TableName].Rows[i][j] != DBNull.Value) {
					DTable.Rows[i].Cells[j].Value = Data.Tables[TableName].Rows[i][j];
				}
				else {
					DTable.Rows[i].Cells[j].Value = null;
				}
			}
		}
	}
}
}