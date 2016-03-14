namespace BankLab
{
	partial class RegressionForm
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
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.StartButton = new System.Windows.Forms.Button();
			this.BackButton = new System.Windows.Forms.Button();
			this.back_button = new System.Windows.Forms.Button();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(500, 30);
			this.title_label.TabIndex = 10;
			this.title_label.Text = "Регрессия для ";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.StartButton);
			this.ButtonPanel.Controls.Add(this.BackButton);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 260);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(500, 40);
			this.ButtonPanel.TabIndex = 11;
			// 
			// StartButton
			// 
			this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartButton.Location = new System.Drawing.Point(298, 7);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(190, 23);
			this.StartButton.TabIndex = 1;
			this.StartButton.Text = "Сохранить значение";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(12, 7);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(190, 23);
			this.BackButton.TabIndex = 0;
			this.BackButton.Text = "Назад к выбору параметров";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// back_button
			// 
			this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.back_button.Location = new System.Drawing.Point(322, 5);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(155, 20);
			this.back_button.TabIndex = 12;
			this.back_button.Text = "Назад к главной таблице";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_button_Click);
			// 
			// RegressionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 300);
			this.Controls.Add(this.back_button);
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegressionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegressionForm";
			this.Load += new System.EventHandler(this.RegressionForm_Load);
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Label title_label;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.Button back_button;
	}
}