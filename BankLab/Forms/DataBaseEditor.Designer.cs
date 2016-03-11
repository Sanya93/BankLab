namespace BankLab
{
	partial class DataBaseEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.title_label = new System.Windows.Forms.Label();
			this.back_btn = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.TableList = new System.Windows.Forms.ListBox();
			this.RemoveTableComboBox = new System.Windows.Forms.ComboBox();
			this.TableNameEdit = new System.Windows.Forms.TextBox();
			this.TableNameAddLabel = new System.Windows.Forms.Label();
			this.TableDeleteLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(340, 30);
			this.title_label.TabIndex = 8;
			this.title_label.Text = "Редактировать базу данных";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(114, 243);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(117, 23);
			this.back_btn.TabIndex = 10;
			this.back_btn.Text = "Назад";
			this.back_btn.UseVisualStyleBackColor = true;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(249, 208);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(87, 23);
			this.AddButton.TabIndex = 11;
			this.AddButton.Text = "Добавить";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			this.RemoveButton.Location = new System.Drawing.Point(249, 171);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(87, 23);
			this.RemoveButton.TabIndex = 12;
			this.RemoveButton.Text = "Удалить";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// TableList
			// 
			this.TableList.FormattingEnabled = true;
			this.TableList.Location = new System.Drawing.Point(3, 33);
			this.TableList.MultiColumn = true;
			this.TableList.Name = "TableList";
			this.TableList.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.TableList.Size = new System.Drawing.Size(333, 134);
			this.TableList.TabIndex = 13;
			// 
			// RemoveTableComboBox
			// 
			this.RemoveTableComboBox.FormattingEnabled = true;
			this.RemoveTableComboBox.Location = new System.Drawing.Point(101, 173);
			this.RemoveTableComboBox.Name = "RemoveTableComboBox";
			this.RemoveTableComboBox.Size = new System.Drawing.Size(142, 21);
			this.RemoveTableComboBox.TabIndex = 14;
			// 
			// TableNameEdit
			// 
			this.TableNameEdit.Location = new System.Drawing.Point(101, 211);
			this.TableNameEdit.Name = "TableNameEdit";
			this.TableNameEdit.Size = new System.Drawing.Size(142, 20);
			this.TableNameEdit.TabIndex = 15;
			// 
			// TableNameAddLabel
			// 
			this.TableNameAddLabel.AutoSize = true;
			this.TableNameAddLabel.Location = new System.Drawing.Point(12, 213);
			this.TableNameAddLabel.Name = "TableNameAddLabel";
			this.TableNameAddLabel.Size = new System.Drawing.Size(83, 13);
			this.TableNameAddLabel.TabIndex = 16;
			this.TableNameAddLabel.Text = "Новая таблица";
			// 
			// TableDeleteLabel
			// 
			this.TableDeleteLabel.AutoSize = true;
			this.TableDeleteLabel.Location = new System.Drawing.Point(12, 176);
			this.TableDeleteLabel.Name = "TableDeleteLabel";
			this.TableDeleteLabel.Size = new System.Drawing.Size(50, 13);
			this.TableDeleteLabel.TabIndex = 17;
			this.TableDeleteLabel.Text = "Таблица";
			// 
			// DataBaseEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(340, 278);
			this.Controls.Add(this.TableDeleteLabel);
			this.Controls.Add(this.TableNameAddLabel);
			this.Controls.Add(this.TableNameEdit);
			this.Controls.Add(this.RemoveTableComboBox);
			this.Controls.Add(this.TableList);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.RemoveButton);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DataBaseEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataBaseEditor";
			this.Load += new System.EventHandler(this.DataBaseEditor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title_label;
		private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.ListBox TableList;
		private System.Windows.Forms.ComboBox RemoveTableComboBox;
		private System.Windows.Forms.TextBox TableNameEdit;
		private System.Windows.Forms.Label TableNameAddLabel;
		private System.Windows.Forms.Label TableDeleteLabel;
	}
}