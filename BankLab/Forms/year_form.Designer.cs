namespace BankLab
{
    partial class year_form
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
			this.title_label = new System.Windows.Forms.Label();
			this.start_year_edit = new System.Windows.Forms.TextBox();
			this.end_year_edit = new System.Windows.Forms.TextBox();
			this.ok = new System.Windows.Forms.Button();
			this.tire_label = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(342, 30);
			this.title_label.TabIndex = 0;
			this.title_label.Text = "Введите временной интервал";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// start_year_edit
			// 
			this.start_year_edit.Location = new System.Drawing.Point(30, 45);
			this.start_year_edit.Name = "start_year_edit";
			this.start_year_edit.Size = new System.Drawing.Size(125, 20);
			this.start_year_edit.TabIndex = 1;
			// 
			// end_year_edit
			// 
			this.end_year_edit.Location = new System.Drawing.Point(195, 45);
			this.end_year_edit.Name = "end_year_edit";
			this.end_year_edit.Size = new System.Drawing.Size(125, 20);
			this.end_year_edit.TabIndex = 2;
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(30, 82);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(125, 29);
			this.ok.TabIndex = 3;
			this.ok.Text = "Применить";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// tire_label
			// 
			this.tire_label.AutoSize = true;
			this.tire_label.Location = new System.Drawing.Point(170, 45);
			this.tire_label.Name = "tire_label";
			this.tire_label.Size = new System.Drawing.Size(10, 13);
			this.tire_label.TabIndex = 4;
			this.tire_label.Text = "-";
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(195, 82);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(125, 29);
			this.cancel.TabIndex = 3;
			this.cancel.Text = "Отмена";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// year_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(342, 123);
			this.Controls.Add(this.tire_label);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.end_year_edit);
			this.Controls.Add(this.start_year_edit);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "year_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "year_form";
			this.Load += new System.EventHandler(this.year_form_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.year_form_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox start_year_edit;
        private System.Windows.Forms.TextBox end_year_edit;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label tire_label;
        private System.Windows.Forms.Button cancel;
    }
}