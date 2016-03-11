namespace BankLab
{
	partial class ParamForm
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
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(350, 30);
			this.title_label.TabIndex = 8;
			this.title_label.Text = "Выберите параметры для корреляции:";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ParamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 250);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ParamForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ParamForm";
			this.Load += new System.EventHandler(this.ParamForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Label title_label;
	}
}