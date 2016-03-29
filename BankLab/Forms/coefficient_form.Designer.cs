namespace BankLab
{
    partial class coefficient_form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coefficient_form));
			this.title_label = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.sub_main_menu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.корреляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.back_button = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.sub_main_menu.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// title_label
			// 
			this.title_label.BackColor = System.Drawing.Color.SteelBlue;
			this.title_label.Dock = System.Windows.Forms.DockStyle.Top;
			this.title_label.ForeColor = System.Drawing.Color.White;
			this.title_label.Location = new System.Drawing.Point(0, 0);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(700, 30);
			this.title_label.TabIndex = 7;
			this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusStrip1
			// 
			this.statusStrip1.AllowMerge = false;
			this.statusStrip1.BackColor = System.Drawing.Color.LightGray;
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 378);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(700, 22);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// sub_main_menu
			// 
			this.sub_main_menu.AllowMerge = false;
			this.sub_main_menu.BackColor = System.Drawing.SystemColors.Control;
			this.sub_main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функцииToolStripMenuItem});
			this.sub_main_menu.Location = new System.Drawing.Point(0, 30);
			this.sub_main_menu.Name = "sub_main_menu";
			this.sub_main_menu.Size = new System.Drawing.Size(700, 24);
			this.sub_main_menu.TabIndex = 9;
			this.sub_main_menu.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem,
            this.закрытьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// экспортToolStripMenuItem
			// 
			this.экспортToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("экспортToolStripMenuItem.Image")));
			this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
			this.экспортToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.экспортToolStripMenuItem.Text = "Экспорт";
			this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("закрытьToolStripMenuItem.Image")));
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
			// 
			// функцииToolStripMenuItem
			// 
			this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.корреляцияToolStripMenuItem});
			this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
			this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.функцииToolStripMenuItem.Text = "Функции";
			// 
			// корреляцияToolStripMenuItem
			// 
			this.корреляцияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("корреляцияToolStripMenuItem.Image")));
			this.корреляцияToolStripMenuItem.Name = "корреляцияToolStripMenuItem";
			this.корреляцияToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.корреляцияToolStripMenuItem.Text = "Корреляция";
			this.корреляцияToolStripMenuItem.Click += new System.EventHandler(this.корреляцияToolStripMenuItem_Click);
			// 
			// back_button
			// 
			this.back_button.Location = new System.Drawing.Point(0, 1);
			this.back_button.Name = "back_button";
			this.back_button.Size = new System.Drawing.Size(155, 20);
			this.back_button.TabIndex = 10;
			this.back_button.Text = "Назад к главной таблице";
			this.back_button.UseVisualStyleBackColor = true;
			this.back_button.Click += new System.EventHandler(this.back_button_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.back_button);
			this.panel1.Location = new System.Drawing.Point(526, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(174, 22);
			this.panel1.TabIndex = 11;
			// 
			// coefficient_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(700, 400);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.sub_main_menu);
			this.Controls.Add(this.title_label);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.sub_main_menu;
			this.Name = "coefficient_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "coefficient_form";
			this.Load += new System.EventHandler(this.CoefficientForm_Load);
			this.sub_main_menu.ResumeLayout(false);
			this.sub_main_menu.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip sub_main_menu;
		private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        public System.Windows.Forms.Label title_label;
		private System.Windows.Forms.Button back_button;
		private System.Windows.Forms.ToolStripMenuItem корреляцияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;

    }
}