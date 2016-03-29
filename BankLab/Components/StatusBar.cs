using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BankLab.Components
{
public class StatusBar
{
	private System.Windows.Forms.StatusStrip CurrentStatusBar;
	private BankLab Parent;
	private ToolStripLabel StatusBarLabel;

	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="statusBar">Объект который представляет из себя строку состояния</param>
	/// <param name="statusBarLabel">Текст отображаемый в строке состояния</param>
	/// <param name="parent">Родительская форма</param>
	public StatusBar(System.Windows.Forms.StatusStrip statusBar, ToolStripLabel statusBarLabel, BankLab parent)
	{
		CurrentStatusBar = statusBar;
		StatusBarLabel = statusBarLabel;
		Parent = parent;
		FindControlsOn(Parent);
	}

	/// <summary>
	/// Найти все объекты расположенные на форме
	/// </summary>
	/// <param name="CurrentControl">Исходный объект</param>
	private void FindControlsOn(Object CurrentControl)
	{
		/* Найти MDI окно расположенное внутри главной формы,
		 * если таковое имеется */
		if (CurrentControl.GetType() == typeof(MdiClient)) {
			((Control)CurrentControl).Tag = "Рабочая область";
			((MdiClient)CurrentControl).Name = "MDIConteiner";
			((MdiClient)CurrentControl).DataBindings.Add("BackColor",Parent.Settings, "InActiveColor");
		}
		/* Найти объекты у которых имеется свойство DropDownItems */
		ShowControlInStatusbar(CurrentControl);
		try {
			ToolStripItemCollection Items = (ToolStripItemCollection)
											 (CurrentControl.GetType().GetProperty(
											 "DropDownItems").GetValue(CurrentControl));
			foreach (var Item in Items) {
				FindControlsOn(Item);
			}
		}
		catch (Exception ex) { }

		/* Найти объекты у которых имеется свойство Items */
		try {
			ToolStripItemCollection Items = (ToolStripItemCollection)
											 (CurrentControl.GetType().GetProperty(
											 "Items").GetValue(CurrentControl));
			foreach (ToolStripMenuItem Item in Items) {
				FindControlsOn(Item);
			}
		}
		catch (Exception ex) { }

		/* Найти объекты у которых имеется свойство Controls */
		try {
			System.Windows.Forms.Form.ControlCollection Controls = (System.Windows.Forms.Form.ControlCollection)
										  (CurrentControl.GetType().GetProperty(
										  "Controls").GetValue(CurrentControl));
			foreach (Control Cntrl in Controls) {
				FindControlsOn(Cntrl);
			}
		}
		catch (Exception ex) { }
	}

	/// <summary>
	/// Отобразить подсказку в строке состояния
	/// </summary>
	/// <param name="CurrentControl">Объект отображающийся в строке состояния</param>
	public void ShowControlInStatusbar(Object CurrentControl)
	{
		/* Add EventHandler everyone controls in the current form */
		try {
			EventHandler mouseEnter = (sender, e) =>
			{
				try {
					StatusBarLabel.Text = (sender.GetType().GetProperty("Tag").
													  GetValue(CurrentControl).ToString());
				}
				catch (Exception ex) { }
			};
			EventHandler mouseLeave = (sender, e) =>
			{
				try {
					StatusBarLabel.Text = string.Empty;
				}
				catch (Exception ex) { }
			};
			var _mouse_enter = CurrentControl.GetType().GetEvent("MouseEnter");
			var _mouse_leave = CurrentControl.GetType().GetEvent("MouseLeave");
			_mouse_leave.AddEventHandler(CurrentControl, mouseLeave);
			_mouse_enter.AddEventHandler(CurrentControl, mouseEnter);
		}
		catch (Exception ex) { }
	}
}
}