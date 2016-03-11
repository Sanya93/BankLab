namespace BankLab
{
    partial class save_form
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
			this.name_edit = new System.Windows.Forms.TextBox();
			this.cancel = new System.Windows.Forms.Button();
			this.ok = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
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
			this.title_label.TabIndex = 1;
			this.title_label.Text = "Сохранить базу данных";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// name_edit
			// 
			this.name_edit.Location = new System.Drawing.Point(95, 50);
			this.name_edit.Name = "name_edit";
			this.name_edit.Size = new System.Drawing.Size(232, 20);
			this.name_edit.TabIndex = 2;
			this.name_edit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_edit_KeyDown);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(239, 76);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(88, 29);
			this.cancel.TabIndex = 4;
			this.cancel.Text = "Отмена";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(95, 76);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(138, 29);
			this.ok.TabIndex = 5;
			this.ok.Text = "Выбрать базу данных";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Имя таблицы:";
			// 
			// save_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(340, 125);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.name_edit);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "save_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "save_form";
			this.Load += new System.EventHandler(this.save_form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox name_edit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label label1;
    }
}