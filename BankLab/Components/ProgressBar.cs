using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLab.Components
{
public class ProgressBar
{
	ToolStripProgressBar CurrentProgressBar;
	BankLab Parent;

	/// <summary>
	/// Конструктор класса
	/// </summary>
	/// <param name="currentProgressBar">Элемент являющийся ProgressBar</param>
	/// <param name="parent">Родительская форма</param>
	public ProgressBar(ToolStripProgressBar currentProgressBar, BankLab parent)
	{
		CurrentProgressBar = currentProgressBar;
		Parent = parent;
	}

	/// <summary>
	/// Установить значение в ProgressBar
	/// </summary>
	/// <param name="Progress">Значение</param>
	public void SetProgressBarValue(int Progress)
	{
		CurrentProgressBar.Value = Progress;
	}

	/// <summary>
	/// Получить текущее значение ProgressBar
	/// </summary>
	/// <returns></returns>
	public int GetProgressBarValue()
	{
		return CurrentProgressBar.Value;
	}

	/// <summary>
	/// Показать ProgressBar на форме
	/// </summary>
	public void ShowProgressBar()
	{
		CurrentProgressBar.Value = 0;
		CurrentProgressBar.Visible = true;
	}

	/// <summary>
	/// Скрыть ProgressBar
	/// </summary>
	public void HideProgressBar()
	{
		CurrentProgressBar.Visible = false;
	}
}
}