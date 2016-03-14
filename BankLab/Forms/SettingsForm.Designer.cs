namespace BankLab
{
	partial class SettingsForm
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
			this.ActiveColorBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UnactiveColorBox = new System.Windows.Forms.PictureBox();
			this.TitleColorBox = new System.Windows.Forms.PictureBox();
			this.ColorBox = new System.Windows.Forms.GroupBox();
			this.DownPanel = new System.Windows.Forms.Panel();
			this.SetDefaultSettings = new System.Windows.Forms.LinkLabel();
			this.StartupSetting = new System.Windows.Forms.CheckBox();
			this.ShowSidebarSetting = new System.Windows.Forms.CheckBox();
			this.back_button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ActiveColorBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UnactiveColorBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleColorBox)).BeginInit();
			this.ColorBox.SuspendLayout();
			this.DownPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(400, 30);
			this.title_label.TabIndex = 8;
			this.title_label.Text = "Настройки программы";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ActiveColorBox
			// 
			this.ActiveColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ActiveColorBox.Location = new System.Drawing.Point(340, 25);
			this.ActiveColorBox.Name = "ActiveColorBox";
			this.ActiveColorBox.Size = new System.Drawing.Size(20, 18);
			this.ActiveColorBox.TabIndex = 9;
			this.ActiveColorBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Цвет активного окна";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(6, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Цвет заголовка";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Цвет неактивного окна";
			// 
			// UnactiveColorBox
			// 
			this.UnactiveColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UnactiveColorBox.Location = new System.Drawing.Point(340, 65);
			this.UnactiveColorBox.Name = "UnactiveColorBox";
			this.UnactiveColorBox.Size = new System.Drawing.Size(20, 18);
			this.UnactiveColorBox.TabIndex = 13;
			this.UnactiveColorBox.TabStop = false;
			// 
			// TitleColorBox
			// 
			this.TitleColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TitleColorBox.Location = new System.Drawing.Point(340, 105);
			this.TitleColorBox.Name = "TitleColorBox";
			this.TitleColorBox.Size = new System.Drawing.Size(20, 18);
			this.TitleColorBox.TabIndex = 14;
			this.TitleColorBox.TabStop = false;
			// 
			// ColorBox
			// 
			this.ColorBox.Controls.Add(this.label1);
			this.ColorBox.Controls.Add(this.TitleColorBox);
			this.ColorBox.Controls.Add(this.ActiveColorBox);
			this.ColorBox.Controls.Add(this.UnactiveColorBox);
			this.ColorBox.Controls.Add(this.label2);
			this.ColorBox.Controls.Add(this.label3);
			this.ColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ColorBox.Location = new System.Drawing.Point(12, 42);
			this.ColorBox.Name = "ColorBox";
			this.ColorBox.Size = new System.Drawing.Size(376, 137);
			this.ColorBox.TabIndex = 15;
			this.ColorBox.TabStop = false;
			this.ColorBox.Text = "Настройка цвета";
			// 
			// DownPanel
			// 
			this.DownPanel.Controls.Add(this.back_button);
			this.DownPanel.Controls.Add(this.SetDefaultSettings);
			this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.DownPanel.Location = new System.Drawing.Point(0, 246);
			this.DownPanel.Name = "DownPanel";
			this.DownPanel.Size = new System.Drawing.Size(400, 31);
			this.DownPanel.TabIndex = 16;
			// 
			// SetDefaultSettings
			// 
			this.SetDefaultSettings.AutoSize = true;
			this.SetDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SetDefaultSettings.Location = new System.Drawing.Point(234, 9);
			this.SetDefaultSettings.Name = "SetDefaultSettings";
			this.SetDefaultSettings.Size = new System.Drawing.Size(154, 15);
			this.SetDefaultSettings.TabIndex = 0;
			this.SetDefaultSettings.TabStop = true;
			this.SetDefaultSettings.Text = "Настройки по умолчанию";
			// 
			// StartupSetting
			// 
			this.StartupSetting.AutoSize = true;
			this.StartupSetting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.StartupSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StartupSetting.Location = new System.Drawing.Point(181, 196);
			this.StartupSetting.Name = "StartupSetting";
			this.StartupSetting.Size = new System.Drawing.Size(207, 19);
			this.StartupSetting.TabIndex = 17;
			this.StartupSetting.Text = "Запускать при старте Windows";
			this.StartupSetting.UseVisualStyleBackColor = true;
			// 
			// ShowSidebarSetting
			// 
			this.ShowSidebarSetting.AutoSize = true;
			this.ShowSidebarSetting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ShowSidebarSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShowSidebarSetting.Location = new System.Drawing.Point(95, 221);
			this.ShowSidebarSetting.Name = "ShowSidebarSetting";
			this.ShowSidebarSetting.Size = new System.Drawing.Size(293, 19);
			this.ShowSidebarSetting.TabIndex = 18;
			this.ShowSidebarSetting.Text = "Показывать Диспетчер таблиц по умолчанию";
			this.ShowSidebarSetting.UseVisualStyleBackColor = true;
			// 
			// back_button
			// 
			this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.back_button.Location = new System.Drawing.Point(12, 7);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(155, 20);
			this.back_button.TabIndex = 13;
			this.back_button.Text = "Вернуться к программе";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_button_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 277);
			this.Controls.Add(this.ShowSidebarSetting);
			this.Controls.Add(this.StartupSetting);
			this.Controls.Add(this.DownPanel);
			this.Controls.Add(this.ColorBox);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsForm";
			((System.ComponentModel.ISupportInitialize)(this.ActiveColorBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UnactiveColorBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TitleColorBox)).EndInit();
			this.ColorBox.ResumeLayout(false);
			this.ColorBox.PerformLayout();
			this.DownPanel.ResumeLayout(false);
			this.DownPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label title_label;
		private System.Windows.Forms.PictureBox ActiveColorBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox UnactiveColorBox;
		private System.Windows.Forms.PictureBox TitleColorBox;
		private System.Windows.Forms.GroupBox ColorBox;
		private System.Windows.Forms.Panel DownPanel;
		private System.Windows.Forms.LinkLabel SetDefaultSettings;
		private System.Windows.Forms.CheckBox StartupSetting;
		private System.Windows.Forms.CheckBox ShowSidebarSetting;
		private System.Windows.Forms.Button back_button;
	}
}