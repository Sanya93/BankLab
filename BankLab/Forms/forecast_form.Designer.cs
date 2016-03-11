namespace BankLab
{
    partial class forecast_form 
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
            if (disposing && (components != null))
            {
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
			this.cancel = new System.Windows.Forms.Button();
			this.title_label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.target_coef = new System.Windows.Forms.ComboBox();
			this.constant_edit = new System.Windows.Forms.TextBox();
			this.table = new System.Windows.Forms.DataGridView();
			this.reg_coef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fact_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.result_edit = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(276, 268);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(102, 29);
			this.cancel.TabIndex = 9;
			this.cancel.Text = "Назад";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(400, 30);
			this.title_label.TabIndex = 7;
			this.title_label.Text = "Прогнозирование";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Прогнозируемый коэффициент:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Константа:";
			// 
			// target_coef
			// 
			this.target_coef.FormattingEnabled = true;
			this.target_coef.Location = new System.Drawing.Point(28, 72);
			this.target_coef.Name = "target_coef";
			this.target_coef.Size = new System.Drawing.Size(350, 21);
			this.target_coef.TabIndex = 16;
			this.target_coef.SelectedIndexChanged += new System.EventHandler(this.target_coef_SelectedIndexChanged);
			// 
			// constant_edit
			// 
			this.constant_edit.Location = new System.Drawing.Point(106, 106);
			this.constant_edit.Name = "constant_edit";
			this.constant_edit.Size = new System.Drawing.Size(136, 20);
			this.constant_edit.TabIndex = 17;
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToOrderColumns = true;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reg_coef,
            this.fact_value});
			this.table.Location = new System.Drawing.Point(27, 141);
			this.table.Name = "table";
			this.table.RowHeadersVisible = false;
			this.table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.table.Size = new System.Drawing.Size(353, 84);
			this.table.TabIndex = 18;
			// 
			// reg_coef
			// 
			this.reg_coef.HeaderText = "Коэффициент регрессии";
			this.reg_coef.Name = "reg_coef";
			this.reg_coef.ReadOnly = true;
			this.reg_coef.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.reg_coef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.reg_coef.Width = 150;
			// 
			// fact_value
			// 
			this.fact_value.HeaderText = "Среднее значение фактора";
			this.fact_value.Name = "fact_value";
			this.fact_value.Width = 200;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Прогнозируемое значение:";
			// 
			// result_edit
			// 
			this.result_edit.Location = new System.Drawing.Point(176, 237);
			this.result_edit.Name = "result_edit";
			this.result_edit.Size = new System.Drawing.Size(204, 20);
			this.result_edit.TabIndex = 20;
			// 
			// forecast_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(400, 309);
			this.Controls.Add(this.result_edit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.table);
			this.Controls.Add(this.constant_edit);
			this.Controls.Add(this.target_coef);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "forecast_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "open_form";
			this.Load += new System.EventHandler(this.forecast_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label title_label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox target_coef;
		private System.Windows.Forms.TextBox constant_edit;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.DataGridViewTextBoxColumn reg_coef;
		private System.Windows.Forms.DataGridViewTextBoxColumn fact_value;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox result_edit;

    }
}