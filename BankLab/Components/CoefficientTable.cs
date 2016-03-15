using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BankLab.Components
{
	public class CoefficientTable
	{
		private DataGridView Table;
		private BankLab Parent;
		private coefficient_form CurrentForm;
		private int Index;

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="parent">Родительская форма</param>
		/// <param name="Form">Текущая форма для отображения коэффициентов</param>
		public CoefficientTable(BankLab parent, coefficient_form Form)
		{
			Parent = parent;
			CurrentForm = Form;
		}

		/// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="parent">Родительская форма</param>
		public CoefficientTable(BankLab parent)
		{
			Parent = parent;
			CurrentForm = null;
		}

		public void CloseCoefficientChilrenForm()
		{
			Type[] ChildrenTypes = new Type[]{typeof(ParamForm),typeof(CorrelationForm),typeof(RegressionForm)};
			foreach (Type type in ChildrenTypes) {
				Form tmp_form = Parent.MDI.GetMDIFormByType(type);
				if (tmp_form != null) {
					Form NextForm = Parent.MDI.GetNextForm(tmp_form);
					if (NextForm != null) { 
						NextForm.GetType().GetMethod("SetPreviousForm").Invoke(NextForm,new object[]{CurrentForm});
					}
					tmp_form.Close();
				}	
			}
		}

		public void SwitchCoefficientForm(int Index)
		{
			CloseCoefficientChilrenForm();
			if (Parent.CurrentCoefficientForm.GetCurrentCoefficientForm() == null) {
				ShowCoefficientForm(Index);
			}
			else {
				Parent.MDI.TryShowMDIForm(typeof(coefficient_form));
				Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().SetIndex(Index);
				Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().AddTableAtForm();
			}
		}

		public void CoefficientClickDelegate(Object sender, EventArgs e)
		{
			if (Parent.CurrentDataTable.GetDataTable().RowCount > 0) {
				int Index = Array.IndexOf(bl_res_styles.bl_helper.Knames,
					sender.GetType().GetProperty("Text").GetValue(sender).ToString());
				SwitchCoefficientForm(Index);
			}
		}

		public void ShowCoefficientForm(int Index)
		{
			if ((Index != -1) && (CurrentForm == null)) {
				CurrentForm = new coefficient_form(null, 0);
			}
			object[] Params = new object[2];
			Params[0] = Parent;
			Params[1] = Index;
			Parent.MDI.ShowMDIForm(CurrentForm, Params);
		}

		public coefficient_form GetCurrentCoefficientForm()
		{
			return CurrentForm;
		}

		public void  SetCurrentCoefficientForm(coefficient_form Value)
		{
			CurrentForm = Value;
		}

		public DataGridView GetCoefficientTable()
		{
			return Table;
		}

		public int GetIndexOfCoefficientTable()
		{
			return Index;
		}

		public DataGridView CreateCoefficientTable(int index)
		{
			Index = index;
			Table = new DataGridView();
			Table.Name = "Table";
			Table.Left -= 1;
			Table.RowHeadersVisible = false;
			for (int i = 0; i <= bl_res_styles.bl_helper.Kindexes.GetUpperBound(1); i++) {
				if ((bl_res_styles.bl_helper.Kindexes[index, i] != int.MaxValue) &&
					(bl_res_styles.bl_helper.Kindexes[index, i] != -1)) {
					Table.Columns.Add(
						(DataGridViewColumn)Parent.CurrentDataTable.GetDataTable().
							Columns[bl_res_styles.bl_helper.Kindexes[index, i]].Clone());
				}
				else {
					if (i == 1)
						Table.Columns.Add("y", "Y, " + bl_res_styles.bl_helper.Knames[index]);
					/* fall-through */
				}
			}
			for (int i = 0; i < Parent.CurrentDataTable.GetDataTable().Rows.Count; i++) {
				Table.Rows.Add();
				for (int j = 0; j <= bl_res_styles.bl_helper.Kindexes.GetUpperBound(1); j++) {
					if ((bl_res_styles.bl_helper.Kindexes[index, j] != int.MaxValue) &&
						(bl_res_styles.bl_helper.Kindexes[index, j] != -1)) {
						Table.Rows[i].Cells[j].Value = Parent.CurrentDataTable.GetDataTable().Rows[i].
									Cells[bl_res_styles.bl_helper.Kindexes[index, j]].Value;
					}
				}
				if (Parent.CurrentDataBase.GetTableName() != string.Empty) {
					if (Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[0].Rows[i][index + 19] == DBNull.Value) {
						bl_res_styles.bl_helper.Kfunctions[
									bl_res_styles.bl_helper.Kfunc_indexes[index]](i, Table);
						Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[0].Rows[i][index + 19] =
																Table.Rows[i].Cells[1].Value;
					}
					else {
						Table.Rows[i].Cells[1].Value = Parent.CurrentDataBase.GetCurrentDataBase().GetDataSet().Tables[0].
																	Rows[i][index + 19];
					}
				}
				else {
					bl_res_styles.bl_helper.Kfunctions[bl_res_styles.bl_helper.Kfunc_indexes[
																			index]](i, Table);
				}
			}
			return Table;
		}
	}
}