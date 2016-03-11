using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLab.Components
{
public class MDIForms
{
	private BankLab Parent;
	
	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="parent"></param>
	public MDIForms(BankLab parent)
	{
		Parent = parent;
	}

	/// <summary>
	/// Выполняет отображение MDIформы любого типа на родительской форме
	/// </summary>
	/// <param name="CurrentForm">Экземпляр отображаемой формы</param>
	public void ShowMDIForm(Form CurrentForm, object[] Params)
	{
		Type[] Types = new Type[0];
		if (Params != null) {
			Types = new Type[Params.Count()];
			for (int i = 0; i < Params.Count(); i++) {
				Types[i] = Params[i].GetType();
			}
		}
		System.Reflection.ConstructorInfo Constructor = CurrentForm.GetType().GetConstructor(Types);
		CurrentForm = (Form)Constructor.Invoke(Params);
		Parent.CurrentMenu.GetCurrentMenu().Enabled = false;
		Parent.CurrentDataTable.GetDataTable().Visible = false;
		CurrentForm.MdiParent = Parent;
		CurrentForm.Visible = false;
		System.Reflection.MethodInfo CheckBeforeShow = CurrentForm.GetType().GetMethod("CheckBeforeShow");
		if (CheckBeforeShow != null) {
			CheckBeforeShow.Invoke(CurrentForm, null);
		}
		else {
			CurrentForm.Show();
		}
	}	
}
}