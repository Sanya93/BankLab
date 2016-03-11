namespace BankLab
{
    partial class open_form
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
			this.ok = new System.Windows.Forms.Button();
			this.title_label = new System.Windows.Forms.Label();
			this.TableListBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FileNameEdit = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(187, 119);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(102, 29);
			this.cancel.TabIndex = 9;
			this.cancel.Text = "Отмена";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(85, 119);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(96, 29);
			this.ok.TabIndex = 10;
			this.ok.Text = "Открыть";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(340, 30);
			this.title_label.TabIndex = 7;
			this.title_label.Text = "Открыть базу данных";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TableListBox
			// 
			this.TableListBox.FormattingEnabled = true;
			this.TableListBox.Location = new System.Drawing.Point(85, 82);
			this.TableListBox.Name = "TableListBox";
			this.TableListBox.Size = new System.Drawing.Size(204, 21);
			this.TableListBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Имя файла:";
			// 
			// FileNameEdit
			// 
			this.FileNameEdit.Location = new System.Drawing.Point(85, 49);
			this.FileNameEdit.Name = "FileNameEdit";
			this.FileNameEdit.ReadOnly = true;
			this.FileNameEdit.Size = new System.Drawing.Size(204, 20);
			this.FileNameEdit.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(5)), true);
			this.button1.Location = new System.Drawing.Point(295, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 21);
			this.button1.TabIndex = 14;
			this.button1.Text = "...";
			this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Таблица:";
			// 
			// open_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(340, 160);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.FileNameEdit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TableListBox);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "open_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "open_form";
			this.Load += new System.EventHandler(this.open_form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label title_label;
		private System.Windows.Forms.ComboBox TableListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FileNameEdit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;

    }
}