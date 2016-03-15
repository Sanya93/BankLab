using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace BankLab.Components
{
public class SideBar
{
	private Panel SideBarPanel;
	private Splitter SideBarSplitter;
	private BankLab FormParent;
	private Label SideBarTitle;
	private Panel Surface;

	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="Caption">Заголовок для боковой панели</param>
	/// <param name="parent">Боковая панель</param>
	/// <param name="splitter">Сплиттер</param>
	/// <param name="formParent">Родительская форма</param>
	public SideBar(String Caption, Control parent, Splitter splitter, BankLab formParent)
	{
		SideBarSplitter = splitter;
		SideBarPanel = (Panel)parent;
		FormParent = formParent;
		SideBarTitle = CreateSideBarTitle(Caption);
	}

	/// <summary>
	/// Скрыть/Показать прогресс бар
	/// </summary>
	public void StartFlowSideBar()
	{
		SplitterAnimationTick();
	}

	/// <summary>
	/// Создать заголовок боковой панели
	/// </summary>
	/// <param name="Caption"></param>
	private Label CreateSideBarTitle(string Caption)
	{
		if (SideBarPanel != null) {
			Label sidebar_text = new Label();
			sidebar_text.Text = Caption;
			sidebar_text.Dock = DockStyle.Top;
			sidebar_text.TextAlign = ContentAlignment.MiddleCenter;
			sidebar_text.Parent = SideBarPanel;
			sidebar_text.BackColor = System.Drawing.Color.SteelBlue;
			sidebar_text.ForeColor = Color.White;
			Surface = new Panel();
			Surface.Parent = SideBarPanel;
			Surface.Dock = DockStyle.Top;
			Surface.AutoSize = true;
			Surface.BringToFront();
			return sidebar_text;
		}
		return null;
	}

	public void ClearSideBar()
	{
		Surface.Controls.Clear();
	}

	private void CoefItemMouseEnter(Object Sender, EventArgs e)
	{
		((Label)Sender).BackColor = Color.SteelBlue;
		((Label)Sender).ForeColor = Color.White;
	}

	private void CoefItemMouseLeave(Object Sender, EventArgs e)
	{
		((Label)Sender).BackColor = Color.Transparent;
		((Label)Sender).ForeColor = Color.Black;
	}

	private void CoefItemClick(Object Sender, EventArgs e)
	{
		int Index = bl_res_styles.bl_helper.Knames.ToList().IndexOf(((Label)Sender).Text);
		FormParent.CurrentCoefficientForm.SwitchCoefficientForm(Index);
	}

	public int AddTables()
	{
		SideBarPanel.Padding = new Padding(2, 0, 0, 0);
		for (int i = 0; i < bl_res_styles.bl_helper.Knames.Count(); i++) {
			Panel LabelPanel = new Panel();
			Label Tmp = new Label();
			LabelPanel.Dock = DockStyle.Top;
			LabelPanel.BorderStyle = BorderStyle.FixedSingle;
			LabelPanel.AutoSize = true;
			Tmp.Dock = DockStyle.Top;
			Tmp.Height = 30;
			Tmp.TextAlign = ContentAlignment.MiddleCenter;
			Tmp.Text = bl_res_styles.bl_helper.Knames[i];
			Tmp.Parent = LabelPanel;
			LabelPanel.Padding = new Padding(0, 10, 0, 0);
			LabelPanel.Parent = Surface;
			Tmp.MouseEnter += CoefItemMouseEnter;
			Tmp.MouseLeave += CoefItemMouseLeave;
			Tmp.Click += CoefItemClick;
			Tmp.BorderStyle = BorderStyle.FixedSingle;
			LabelPanel.BringToFront();
		}
		return 1;
	}

	/// <summary>
	/// Событие представляющее собой анимацию боковой панели
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void SplitterAnimationTick()
	{
			if (SideBarPanel.Width <= 0) {
				SideBarTitle.Hide();
				Surface.Hide();
				while (SideBarPanel.Width < 190) {
					Thread.Sleep(5);
					SideBarPanel.Width += 10;
				}
				SideBarTitle.Show();
				Surface.Show();
				SideBarSplitter.Enabled = true;
				SideBarSplitter.Width = 2;
				SideBarPanel.MinimumSize = new System.Drawing.Size(120, 0);
			}
			else {
				SideBarPanel.MinimumSize = new System.Drawing.Size();
				while (SideBarPanel.Width > 0) {
					SideBarPanel.Width -= 10;
					Surface.Hide();
					Thread.Sleep(5);
				}
				SideBarSplitter.Enabled = false;
				SideBarPanel.Width = 0;
			}
	}
}
}
