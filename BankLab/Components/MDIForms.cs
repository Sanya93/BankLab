using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

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
		//Parent.CurrentMenu.GetCurrentMenu().Enabled = false;
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

	public Form GetMDIFormByType(Type type)
	{
		return Parent.MdiChildren.FirstOrDefault(form => form.GetType() == type);
	}

	public Form GetCurrentVisibleForm()
	{
		return Parent.MdiChildren.FirstOrDefault(form => form.Visible);
	}

	public void ChangeLink(Form currentForm)
	{
		Form NextForm = Parent.MdiChildren.First(
			form => {
				MethodInfo Method = form.GetType().GetMethod("GetPreviousForm");
				if (Method != null) { 
					Form tmp_form = (Form)Method.Invoke(form,null); 
					return tmp_form == currentForm; 
				}
				else {
					return false;
				}
			});	
		Form PreviousForm = (Form)currentForm.GetType().GetMethod("GetPreviousForm").Invoke(currentForm,null);
		NextForm.GetType().GetMethod("SetPreviousForm").Invoke(NextForm,new object[]{PreviousForm});
	}

	public int TryShowMDIForm(Type type)
	{
		Form ExistForm = GetMDIFormByType(type);
		Form CurrentVisibleForm = GetCurrentVisibleForm();
		if (ExistForm != null) {
			if (CurrentVisibleForm != null) {
				if (CurrentVisibleForm.GetType() == type) {
					return 1;
				}
				CurrentVisibleForm.Hide();
			}
			else {
				Parent.CurrentDataTable.GetDataTable().Hide();
			}
			ChangeLink(ExistForm);
			ExistForm.GetType().GetMethod("SetPreviousForm").Invoke(ExistForm,new object[]{CurrentVisibleForm});
			ExistForm.Show();
			return 1;
		}
		return 0;
	}
}
}