using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BankLab.Components
{
public class Menu
{
	private BankLab Parent;
	private MenuStrip CurrentMenu;
	
	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="parent">Родительская форма меню</param>
	/// <param name="currentMenu">Текущий элемент играющий роль меню на форме</param>
	public Menu(BankLab parent, MenuStrip currentMenu)
	{
		Parent = parent;
		CurrentMenu = currentMenu;
	}

	/// <summary>
	/// Изменить доступность элементов меню на выбранное значение
	/// </summary>
	/// <param name="Enabled">Укажите значение которое хотите установить для пунктов меню</param>
	public void ChangeMenuItemsEnable(bool Enabled)
	{
		CurrentMenu.Items.Find("изменитьИнтервалToolStripMenuItem", true)[0].Enabled = Enabled;
		CurrentMenu.Items.Find("сохранитьToolStripMenuItem", true)[0].Enabled = Enabled;
		CurrentMenu.Items.Find("сохранитьКакToolStripMenuItem", true)[0].Enabled = Enabled;
		CurrentMenu.Items.Find("закрытьToolStripMenuItem", true)[0].Enabled = Enabled;
		foreach (ToolStripMenuItem CoefficientItem in ((ToolStripMenuItem)
										 CurrentMenu.Items.Find(
										 "формыКоэффициентовToolStripMenuItem",
										 false)[0]).DropDownItems)
		{
			CoefficientItem.Enabled = Enabled;
		}
	}

	/// <summary>
	/// Сделать доступным главное меню
	/// </summary>
	public void SetMainMenuEnableOn()
	{
		CurrentMenu.Enabled = true;
	}

	/// <summary>
	/// Динамическое создание пунктов меню
	/// </summary>
	/// <param name="Captions">Заголовок меню</param>
	/// <param name="ParentMenuItem">Родительский элемент меню</param>
	/// <param name="LayoutItems">Подложка</param>
	/// <param name="Enabled">Доступность элемента по умолчанию</param>
	/// <param name="ClickFunc">Делегат функции на событие Click</param>
	/// <param name="Icon">Иконка</param>
	/// <returns></returns>
	public int CreateDynamicMenuItems(string[] Captions,
									   ToolStripMenuItem ParentMenuItem,
									   bool LayoutItems, bool Enabled, 
									   EventHandler ClickFunc,
									   Image Icon) 
	{
		if (Captions.Count() < 1) {
			return 0;
		}
		else {
			for (int i = 0; i < Captions.Count(); i++) {
				ToolStripMenuItem tmp = new ToolStripMenuItem(Captions[i]);
												//bl_res_styles.bl_helper.Knames[i]);
				if (LayoutItems) {
					/* Layout Settings */
					ToolStripMenuItem layout_tmp = new ToolStripMenuItem(Captions[i]);
												//bl_res_styles.bl_helper.Knames[i]);

					tmp.Margin = new Padding(0, -22, 0, 0);
					layout_tmp.Tag = layout_tmp.Text;
					layout_tmp.Click += ClickFunc;
					layout_tmp.DisplayStyle = ToolStripItemDisplayStyle.None;
					ParentMenuItem.DropDownItems.Add(layout_tmp);
				}
				tmp.Enabled = Enabled;
				tmp.Click += ClickFunc;
				if (Icon != null) {
					tmp.Image = Icon;
				}
				ParentMenuItem.DropDownItems.Add(tmp);
			}
			return 1;
		}
	}
	
	/// <summary>
	/// Возвращает текущий экземпляр меню
	/// </summary>
	/// <returns></returns>
	public MenuStrip GetCurrentMenu()
	{
		return CurrentMenu;
	}
}
}
