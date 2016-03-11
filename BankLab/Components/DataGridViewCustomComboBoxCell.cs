using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace BankLab
{
	class DataGridViewCustomComboBoxCell :DataGridViewComboBoxCell
	{
		protected override void Paint(
					Graphics graphics, 
					Rectangle clipBounds,
					Rectangle cellBounds, 
					int rowIndex, 
					DataGridViewElementStates elementState,
					object value,
					object formattedValue,
					string errorText,
					DataGridViewCellStyle cellStyle,
					DataGridViewAdvancedBorderStyle advancedBorderStyle,
					DataGridViewPaintParts paintParts)
		{
			SolidBrush myBrush = new SolidBrush(System.Drawing.SystemColors.Control);
			graphics.FillRectangle(myBrush, cellBounds);
			cellBounds.X+=2;
			cellBounds.Y+=5;
			cellBounds.Width-=4;
			cellBounds.Height-=10;
			base.Paint(
				graphics, 
				clipBounds, 
				cellBounds, 
				rowIndex, 
				elementState, 
				value, 
				formattedValue, 
				errorText, 
				cellStyle, 
				advancedBorderStyle, 
				paintParts);
		}

		public override void PositionEditingControl(
			bool setLocation,
			bool setSize,
			Rectangle cellBounds,
			Rectangle cellClip,
			DataGridViewCellStyle cellStyle,
			bool singleVerticalBorderAdded,
			bool singleHorizontalBorderAdded,
			bool isFirstDisplayedColumn,
			bool isFirstDisplayedRow)
		{
			cellBounds.X += 1;
			cellBounds.Y += 2;
			cellBounds.Width -= 3;
			this.DataGridView.EditingPanel.BackColor = System.Drawing.SystemColors.Control;
			base.PositionEditingControl(
				setLocation, 
				setSize, 
				cellBounds, 
				cellClip, 
				cellStyle, 
				singleVerticalBorderAdded, 
				singleHorizontalBorderAdded, 
				isFirstDisplayedColumn, 
				isFirstDisplayedRow);
		}
	}
}