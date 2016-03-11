using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLab
{
	public partial class ParamForm : Form
	{
		private BankLab Parent;
		private DataGridView CurrentDataTable;
		private bool[] SelectedColumns;

		public ParamForm(BankLab parent, DataGridView dataTable)
		{
			InitializeComponent();
			Parent = parent;
			CurrentDataTable = dataTable;
			ShowParametrForm(CurrentDataTable);
		}
	
	private void ShowParametrForm(DataGridView Table)
	{
		if (Table != null) {
			int CurrentElementPosition = 0;
			SelectedColumns = new bool[Table.ColumnCount - 1];
			SelectedColumns[0] = true;
			Panel Surface = new Panel();
			Surface.AutoScroll = true;
			Surface.Dock = DockStyle.Fill;
			Surface.Parent = this;
			Surface.BringToFront();
			Surface.HorizontalScroll.Visible = false;
			this.Padding = new Padding(0, 0, 0, 10);
			for (int i = 2; i < Table.ColumnCount; i++) {
				CheckBox CurrentCheckBox = new CheckBox();
				CurrentCheckBox.Location = new Point(15, CurrentElementPosition + 10);
				CurrentCheckBox.Text = Table.Columns[i].HeaderText;
				CurrentCheckBox.Parent = Surface;
				CurrentCheckBox.AutoSize = true;
				CurrentCheckBox.Tag = i - 1;
				CurrentCheckBox.CheckedChanged += (_s, _e) =>
				{
					SelectedColumns[(int)((CheckBox)_s).Tag] = CurrentCheckBox.Checked;
				};
				CurrentCheckBox.Checked = true;
				CurrentElementPosition = CurrentCheckBox.Bottom;
			}
			Button BackButton = new Button();
			BackButton.Text = "Назад";
			BackButton.AutoSize = true;
			BackButton.Click += (_s, _e) =>
			{
				this.Close();
			};
			Button OkButton = new Button();
			OkButton.Text = "Корреляция";
			OkButton.AutoSize = true;
			BackButton.Location = new Point(15, CurrentElementPosition + 10);
			OkButton.Location = new Point(this.Width - OkButton.Width - 10, CurrentElementPosition + 10);
			OkButton.Anchor = AnchorStyles.Right;
			BackButton.Parent = Surface;
			OkButton.Parent = Surface;
			OkButton.Click += StartCorelationDelegate;
		}
	}

	private void StartCorelationDelegate(Object sender, EventArgs e)
	{
		if (IsParametresSelected()) {
			DataGridView CorrelationTable = ExcelFunctions.StartCorelation(SelectedColumns, Parent);
			CorrelationForm CurrentCorrelationForm = new CorrelationForm(null, null, null);
			object[] Params = new object[3];
			Params[0] = Parent;
			Params[1] = this;
			Params[2] = CorrelationTable;
			Parent.MDI.ShowMDIForm(CurrentCorrelationForm, Params);
			this.Hide();
		}
		else {
			MessageBox.Show("Должен быть выбран хотя бы один параметр");
		}
	}

	public bool[] GetSelectedColumns()
	{
		return SelectedColumns;
	}

	private bool IsParametresSelected()
	{
		bool HasParametr=false;
		for (int i = 1; i < SelectedColumns.Length; i++) {
			if (SelectedColumns[i]) HasParametr = true;
		}
		return HasParametr;
	}

	private void CloseParamFormDelegate(object sender, CancelEventArgs e)
	{
		Parent.CurrentCoefficientForm.GetCurrentCoefficientForm().Show();
	}

	private void ParamForm_Load(object sender, EventArgs e)
	{
		this.FormClosing += CloseParamFormDelegate;
	}
}
}