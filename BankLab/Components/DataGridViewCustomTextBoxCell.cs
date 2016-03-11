using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace BankLab
{
	public class DataGridViewCustomTextBoxCell : DataGridViewTextBoxCell
	{
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

		public override void InitializeEditingControl(
					int rowIndex, 
					object initialFormattedValue, 
					DataGridViewCellStyle dataGridViewCellStyle)
		{
			Debug.Assert(this.DataGridView != null &&
						 this.DataGridView.EditingPanel != null &&
						 this.DataGridView.EditingControl != null);
			Debug.Assert(!this.ReadOnly);
			base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
			TextBox textBox = this.DataGridView.EditingControl as TextBox;
			if (textBox != null) {
				textBox.BorderStyle = BorderStyle.Fixed3D;
				textBox.AcceptsReturn = textBox.Multiline = dataGridViewCellStyle.WrapMode == DataGridViewTriState.True;
				textBox.MaxLength = this.MaxInputLength;
				string initialFormattedValueStr = initialFormattedValue as string;
				if (initialFormattedValueStr == null)
				{
					textBox.Text = string.Empty;
				}
				else
				{
					textBox.Text = initialFormattedValueStr;
				}
			}
		}

		protected override void Paint(
					Graphics graphics,
					Rectangle clipBounds,
					Rectangle cellBounds,
					int rowIndex,
					DataGridViewElementStates cellState,
					Object value,
					Object formattedValue,
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
				cellState, 
				value, 
				formattedValue, 
				errorText, 
				cellStyle, 
				advancedBorderStyle, 
				paintParts);
		}

	}
}
