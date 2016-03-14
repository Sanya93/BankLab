namespace BankLab
{
	partial class OptimizationForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.целеваяФункцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.прибыльToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.привлеченныеСредстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.интегрированныйКоэффициентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TargetFunc = new System.Windows.Forms.GroupBox();
			this.TargetPanel = new System.Windows.Forms.Panel();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.title_label = new System.Windows.Forms.Label();
			this.Grid = new System.Windows.Forms.DataGridView();
			this.back_button = new System.Windows.Forms.Button();
			this.MainMenu.SuspendLayout();
			this.TargetFunc.SuspendLayout();
			this.StatusBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.AllowMerge = false;
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.целеваяФункцияToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 30);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(750, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.экспортToolStripMenuItem,
            this.закрытьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новыйToolStripMenuItem
			// 
			this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
			this.новыйToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.новыйToolStripMenuItem.Text = "Новый";
			this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Enabled = false;
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// экспортToolStripMenuItem
			// 
			this.экспортToolStripMenuItem.Enabled = false;
			this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
			this.экспортToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.экспортToolStripMenuItem.Text = "Экспорт";
			this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортДанныхToolStripMenuItem_Click);
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
			// 
			// целеваяФункцияToolStripMenuItem
			// 
			this.целеваяФункцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прибыльToolStripMenuItem,
            this.привлеченныеСредстваToolStripMenuItem,
            this.интегрированныйКоэффициентToolStripMenuItem});
			this.целеваяФункцияToolStripMenuItem.Enabled = false;
			this.целеваяФункцияToolStripMenuItem.Name = "целеваяФункцияToolStripMenuItem";
			this.целеваяФункцияToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
			this.целеваяФункцияToolStripMenuItem.Text = "Целевая функция";
			// 
			// прибыльToolStripMenuItem
			// 
			this.прибыльToolStripMenuItem.Name = "прибыльToolStripMenuItem";
			this.прибыльToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.прибыльToolStripMenuItem.Tag = "0";
			this.прибыльToolStripMenuItem.Text = "Прибыль";
			this.прибыльToolStripMenuItem.Click += new System.EventHandler(this.MenuTargetFunction_Click);
			// 
			// привлеченныеСредстваToolStripMenuItem
			// 
			this.привлеченныеСредстваToolStripMenuItem.Name = "привлеченныеСредстваToolStripMenuItem";
			this.привлеченныеСредстваToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.привлеченныеСредстваToolStripMenuItem.Tag = "1";
			this.привлеченныеСредстваToolStripMenuItem.Text = "Привлеченные средства";
			this.привлеченныеСредстваToolStripMenuItem.Click += new System.EventHandler(this.MenuTargetFunction_Click);
			// 
			// интегрированныйКоэффициентToolStripMenuItem
			// 
			this.интегрированныйКоэффициентToolStripMenuItem.Name = "интегрированныйКоэффициентToolStripMenuItem";
			this.интегрированныйКоэффициентToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.интегрированныйКоэффициентToolStripMenuItem.Tag = "2";
			this.интегрированныйКоэффициентToolStripMenuItem.Text = "Интегрированный коэффициент";
			this.интегрированныйКоэффициентToolStripMenuItem.Click += new System.EventHandler(this.MenuTargetFunction_Click);
			// 
			// TargetFunc
			// 
			this.TargetFunc.Controls.Add(this.TargetPanel);
			this.TargetFunc.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TargetFunc.Location = new System.Drawing.Point(0, 401);
			this.TargetFunc.Name = "TargetFunc";
			this.TargetFunc.Size = new System.Drawing.Size(750, 77);
			this.TargetFunc.TabIndex = 0;
			this.TargetFunc.TabStop = false;
			this.TargetFunc.Text = "Целевая функция: ";
			// 
			// TargetPanel
			// 
			this.TargetPanel.AutoScroll = true;
			this.TargetPanel.BackColor = System.Drawing.SystemColors.Control;
			this.TargetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TargetPanel.Location = new System.Drawing.Point(3, 16);
			this.TargetPanel.Name = "TargetPanel";
			this.TargetPanel.Size = new System.Drawing.Size(744, 58);
			this.TargetPanel.TabIndex = 0;
			// 
			// StatusBar
			// 
			this.StatusBar.BackColor = System.Drawing.Color.LightGray;
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel});
			this.StatusBar.Location = new System.Drawing.Point(0, 478);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(750, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.TabIndex = 0;
			this.StatusBar.Text = "statusStrip1";
			// 
			// ProgressLabel
			// 
			this.ProgressLabel.Name = "ProgressLabel";
			this.ProgressLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(750, 30);
			this.title_label.TabIndex = 8;
			this.title_label.Text = "Оптимизация";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Grid
			// 
			this.Grid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grid.EnableHeadersVisualStyles = false;
			this.Grid.Location = new System.Drawing.Point(0, 54);
			this.Grid.Name = "Grid";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Grid.Size = new System.Drawing.Size(750, 347);
			this.Grid.TabIndex = 9;
			this.Grid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellValueChanged);
			// 
			// back_button
			// 
			this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.back_button.Location = new System.Drawing.Point(679, 32);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(68, 20);
			this.back_button.TabIndex = 11;
			this.back_button.Text = "Назад";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_button_Click);
			// 
			// OptimizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 500);
			this.Controls.Add(this.back_button);
			this.Controls.Add(this.Grid);
			this.Controls.Add(this.TargetFunc);
			this.Controls.Add(this.MainMenu);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.title_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "OptimizationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OptimizationForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptimizationForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.TargetFunc.ResumeLayout(false);
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem целеваяФункцияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem прибыльToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem привлеченныеСредстваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem интегрированныйКоэффициентToolStripMenuItem;
		private System.Windows.Forms.GroupBox TargetFunc;
		private System.Windows.Forms.Panel TargetPanel;
		private System.Windows.Forms.StatusStrip StatusBar;
		private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
		private System.Windows.Forms.Label title_label;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.DataGridView Grid;
		private System.Windows.Forms.Button back_button;
	}
}