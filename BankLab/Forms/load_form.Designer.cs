namespace BankLab
{
    partial class load_form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load_form));
			this.init_proc_label = new System.Windows.Forms.Label();
			this.title_label = new System.Windows.Forms.Label();
			this.excel_ico = new System.Windows.Forms.PictureBox();
			this.pic_to_background = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.excel_ico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_to_background)).BeginInit();
			this.SuspendLayout();
			// 
			// init_proc_label
			// 
			this.init_proc_label.AutoSize = true;
			this.init_proc_label.Location = new System.Drawing.Point(22, 234);
			this.init_proc_label.Name = "init_proc_label";
			this.init_proc_label.Size = new System.Drawing.Size(206, 13);
			this.init_proc_label.TabIndex = 1;
			this.init_proc_label.Text = "Процесс инициализации приложения...";
			// 
			// title_label
			// 
			this.title_label.AutoSize = true;
			this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.title_label.Location = new System.Drawing.Point(22, 7);
			this.title_label.Name = "title_label";
			this.title_label.Size = new System.Drawing.Size(264, 34);
			this.title_label.TabIndex = 1;
			this.title_label.Text = "Расчет финансовой устойчивости\r\nбанка";
			this.title_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// excel_ico
			// 
			this.excel_ico.Image = ((System.Drawing.Image)(resources.GetObject("excel_ico.Image")));
			this.excel_ico.Location = new System.Drawing.Point(268, 221);
			this.excel_ico.Name = "excel_ico";
			this.excel_ico.Size = new System.Drawing.Size(26, 26);
			this.excel_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.excel_ico.TabIndex = 2;
			this.excel_ico.TabStop = false;
			// 
			// pic_to_background
			// 
			this.pic_to_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic_to_background.Image = ((System.Drawing.Image)(resources.GetObject("pic_to_background.Image")));
			this.pic_to_background.Location = new System.Drawing.Point(0, 0);
			this.pic_to_background.Margin = new System.Windows.Forms.Padding(0);
			this.pic_to_background.Name = "pic_to_background";
			this.pic_to_background.Size = new System.Drawing.Size(305, 255);
			this.pic_to_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_to_background.TabIndex = 0;
			this.pic_to_background.TabStop = false;
			// 
			// load_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 255);
			this.Controls.Add(this.excel_ico);
			this.Controls.Add(this.title_label);
			this.Controls.Add(this.init_proc_label);
			this.Controls.Add(this.pic_to_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "load_form";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "load_form";
			this.Load += new System.EventHandler(this.load_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.excel_ico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_to_background)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_to_background;
        private System.Windows.Forms.Label init_proc_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox excel_ico;

    }
}

