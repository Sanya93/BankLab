namespace BankLab
{
    partial class BankLab
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankLab));
			this.status_bar = new System.Windows.Forms.StatusStrip();
			this.toolstrip_progressbar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolstrip_label = new System.Windows.Forms.ToolStripStatusLabel();
			this.sidebar_panel = new System.Windows.Forms.Panel();
			this.sidebar_splitter = new System.Windows.Forms.Splitter();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранить_back = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранить_какBack = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрыть_back = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьИнтервал_back = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьИнтервалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.показатьСкрытьБоковуюПанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.формыКоэффициентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.диспетчерБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.main_menu = new System.Windows.Forms.MenuStrip();
			this.дествиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.прогнозированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оптимизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.status_bar.SuspendLayout();
			this.main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// status_bar
			// 
			this.status_bar.AutoSize = false;
			this.status_bar.BackColor = System.Drawing.Color.LightGray;
			this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_progressbar,
            this.toolstrip_label});
			this.status_bar.Location = new System.Drawing.Point(0, 462);
			this.status_bar.Name = "status_bar";
			this.status_bar.Size = new System.Drawing.Size(807, 20);
			this.status_bar.TabIndex = 2;
			this.status_bar.Text = "statusStrip1";
			// 
			// toolstrip_progressbar
			// 
			this.toolstrip_progressbar.Name = "toolstrip_progressbar";
			this.toolstrip_progressbar.Size = new System.Drawing.Size(100, 14);
			this.toolstrip_progressbar.Tag = "T";
			this.toolstrip_progressbar.Visible = false;
			// 
			// toolstrip_label
			// 
			this.toolstrip_label.Name = "toolstrip_label";
			this.toolstrip_label.Size = new System.Drawing.Size(0, 15);
			// 
			// sidebar_panel
			// 
			this.sidebar_panel.BackColor = System.Drawing.SystemColors.Control;
			this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar_panel.Location = new System.Drawing.Point(0, 24);
			this.sidebar_panel.MaximumSize = new System.Drawing.Size(250, 0);
			this.sidebar_panel.Name = "sidebar_panel";
			this.sidebar_panel.Size = new System.Drawing.Size(0, 438);
			this.sidebar_panel.TabIndex = 7;
			// 
			// sidebar_splitter
			// 
			this.sidebar_splitter.BackColor = System.Drawing.SystemColors.Control;
			this.sidebar_splitter.Enabled = false;
			this.sidebar_splitter.Location = new System.Drawing.Point(0, 24);
			this.sidebar_splitter.Margin = new System.Windows.Forms.Padding(0);
			this.sidebar_splitter.MaximumSize = new System.Drawing.Size(150, 0);
			this.sidebar_splitter.MinSize = 0;
			this.sidebar_splitter.Name = "sidebar_splitter";
			this.sidebar_splitter.Size = new System.Drawing.Size(2, 438);
			this.sidebar_splitter.TabIndex = 0;
			this.sidebar_splitter.TabStop = false;
			this.sidebar_splitter.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sidebar_splitter_SplitterMoved);
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранить_back,
            this.сохранитьToolStripMenuItem,
            this.сохранить_какBack,
            this.сохранитьКакToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.закрыть_back,
            this.закрытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Tag = "";
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новыйToolStripMenuItem
			// 
			this.новыйToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.новыйToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыйToolStripMenuItem.Image")));
			this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
			this.новыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.новыйToolStripMenuItem.Tag = "Создание нового файла";
			this.новыйToolStripMenuItem.Text = "Создать";
			this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.открытьToolStripMenuItem.Tag = "Открыть базу данных";
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранить_back
			// 
			this.сохранить_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.сохранить_back.Name = "сохранить_back";
			this.сохранить_back.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.сохранить_back.Size = new System.Drawing.Size(180, 21);
			this.сохранить_back.Tag = "Сохранить базу данных";
			this.сохранить_back.Text = "toolStripMenuItem1";
			this.сохранить_back.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.сохранитьToolStripMenuItem.Enabled = false;
			this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
			this.сохранитьToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, -22, 0, 0);
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьToolStripMenuItem.Tag = "Сохранить базу данных";
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранить_какBack
			// 
			this.сохранить_какBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.сохранить_какBack.Name = "сохранить_какBack";
			this.сохранить_какBack.Size = new System.Drawing.Size(180, 22);
			this.сохранить_какBack.Tag = "Сохранить в другую базу данных";
			this.сохранить_какBack.Text = "Сохранить как";
			this.сохранить_какBack.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Enabled = false;
			this.сохранитьКакToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, -22, 0, 0);
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьКакToolStripMenuItem.Tag = "Сохранить в базу данных";
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// импортToolStripMenuItem
			// 
			this.импортToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.импортToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("импортToolStripMenuItem.Image")));
			this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
			this.импортToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.импортToolStripMenuItem.Tag = "Импорт файла Microsoft Excel";
			this.импортToolStripMenuItem.Text = "Импорт";
			this.импортToolStripMenuItem.Click += new System.EventHandler(this.импортToolStripMenuItem_Click);
			// 
			// закрыть_back
			// 
			this.закрыть_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.закрыть_back.Name = "закрыть_back";
			this.закрыть_back.Size = new System.Drawing.Size(180, 22);
			this.закрыть_back.Tag = "Закрыть документ";
			this.закрыть_back.Text = "Закрыть";
			this.закрыть_back.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.закрытьToolStripMenuItem.Enabled = false;
			this.закрытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("закрытьToolStripMenuItem.Image")));
			this.закрытьToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, -22, 0, 0);
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.закрытьToolStripMenuItem.Tag = "Закрыть документ";
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.BackColor = System.Drawing.Color.Gray;
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.выходToolStripMenuItem.Tag = "Выход из программы";
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьИнтервал_back,
            this.изменитьИнтервалToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.правкаToolStripMenuItem.Text = "Правка";
			// 
			// изменитьИнтервал_back
			// 
			this.изменитьИнтервал_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
			this.изменитьИнтервал_back.Name = "изменитьИнтервал_back";
			this.изменитьИнтервал_back.Size = new System.Drawing.Size(182, 22);
			this.изменитьИнтервал_back.Tag = "Изменить интервал расчета";
			this.изменитьИнтервал_back.Text = "Изменить интервал";
			this.изменитьИнтервал_back.Click += new System.EventHandler(this.изменитьИнтервалToolStripMenuItem_Click);
			// 
			// изменитьИнтервалToolStripMenuItem
			// 
			this.изменитьИнтервалToolStripMenuItem.Enabled = false;
			this.изменитьИнтервалToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьИнтервалToolStripMenuItem.Image")));
			this.изменитьИнтервалToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, -22, 0, 0);
			this.изменитьИнтервалToolStripMenuItem.Name = "изменитьИнтервалToolStripMenuItem";
			this.изменитьИнтервалToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.изменитьИнтервалToolStripMenuItem.Tag = "Изменить интервал расчета";
			this.изменитьИнтервалToolStripMenuItem.Text = "Изменить интервал";
			this.изменитьИнтервалToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнтервалToolStripMenuItem_Click);
			// 
			// вырезатьToolStripMenuItem
			// 
			this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
			this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
			this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.вырезатьToolStripMenuItem.Tag = "Вырезать текст";
			this.вырезатьToolStripMenuItem.Text = "Вырезать ";
			this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.копироватьToolStripMenuItem.Tag = "Копировать текст";
			this.копироватьToolStripMenuItem.Text = "Копировать";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
			// 
			// вставитьToolStripMenuItem
			// 
			this.вставитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставитьToolStripMenuItem.Image")));
			this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
			this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.вставитьToolStripMenuItem.Tag = "Вставить текст в текущую ячейку";
			this.вставитьToolStripMenuItem.Text = "Вставить";
			this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьToolStripMenuItem.Image")));
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
			this.удалитьToolStripMenuItem.Tag = "Удалить текст";
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьСкрытьБоковуюПанельToolStripMenuItem});
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// показатьСкрытьБоковуюПанельToolStripMenuItem
			// 
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("показатьСкрытьБоковуюПанельToolStripMenuItem.Image")));
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Name = "показатьСкрытьБоковуюПанельToolStripMenuItem";
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Tag = "Показать боковую панель";
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Text = "Показать/Скрыть боковую панель";
			this.показатьСкрытьБоковуюПанельToolStripMenuItem.Click += new System.EventHandler(this.показатьСкрытьБоковуюПанельToolStripMenuItem_Click);
			// 
			// формыКоэффициентовToolStripMenuItem
			// 
			this.формыКоэффициентовToolStripMenuItem.Name = "формыКоэффициентовToolStripMenuItem";
			this.формыКоэффициентовToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
			this.формыКоэффициентовToolStripMenuItem.Text = "Формы коэффициентов";
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПрограммыToolStripMenuItem,
            this.диспетчерБазыДанныхToolStripMenuItem});
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// настройкиПрограммыToolStripMenuItem
			// 
			this.настройкиПрограммыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("настройкиПрограммыToolStripMenuItem.Image")));
			this.настройкиПрограммыToolStripMenuItem.Name = "настройкиПрограммыToolStripMenuItem";
			this.настройкиПрограммыToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.настройкиПрограммыToolStripMenuItem.Tag = "Показать окно настроек программы";
			this.настройкиПрограммыToolStripMenuItem.Text = "Настройки программы";
			// 
			// диспетчерБазыДанныхToolStripMenuItem
			// 
			this.диспетчерБазыДанныхToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("диспетчерБазыДанныхToolStripMenuItem.Image")));
			this.диспетчерБазыДанныхToolStripMenuItem.Name = "диспетчерБазыДанныхToolStripMenuItem";
			this.диспетчерБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.диспетчерБазыДанныхToolStripMenuItem.Tag = "Диспетчер таблиц позволяет редактировать БД";
			this.диспетчерБазыДанныхToolStripMenuItem.Text = "Диспетчер таблиц БД";
			this.диспетчерБазыДанныхToolStripMenuItem.Click += new System.EventHandler(this.диспетчерБазыДанныхToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.оПрограммеToolStripMenuItem.Tag = "Просмотр сведений о программе";
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// main_menu
			// 
			this.main_menu.BackColor = System.Drawing.SystemColors.Control;
			this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.дествиеToolStripMenuItem,
            this.формыКоэффициентовToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.main_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.main_menu.Location = new System.Drawing.Point(0, 0);
			this.main_menu.Name = "main_menu";
			this.main_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.main_menu.Size = new System.Drawing.Size(807, 24);
			this.main_menu.TabIndex = 0;
			this.main_menu.Tag = "";
			this.main_menu.Text = "menuStrip1";
			// 
			// дествиеToolStripMenuItem
			// 
			this.дествиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прогнозированиеToolStripMenuItem,
            this.оптимизацияToolStripMenuItem});
			this.дествиеToolStripMenuItem.Name = "дествиеToolStripMenuItem";
			this.дествиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.дествиеToolStripMenuItem.Text = "Действие";
			// 
			// прогнозированиеToolStripMenuItem
			// 
			this.прогнозированиеToolStripMenuItem.Name = "прогнозированиеToolStripMenuItem";
			this.прогнозированиеToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.прогнозированиеToolStripMenuItem.Text = "Прогнозирование";
			this.прогнозированиеToolStripMenuItem.Click += new System.EventHandler(this.прогнозированиеToolStripMenuItem_Click);
			// 
			// оптимизацияToolStripMenuItem
			// 
			this.оптимизацияToolStripMenuItem.Name = "оптимизацияToolStripMenuItem";
			this.оптимизацияToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.оптимизацияToolStripMenuItem.Text = "Оптимизация";
			this.оптимизацияToolStripMenuItem.Click += new System.EventHandler(this.оптимизацияToolStripMenuItem_Click);
			// 
			// BankLab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(807, 482);
			this.Controls.Add(this.sidebar_splitter);
			this.Controls.Add(this.sidebar_panel);
			this.Controls.Add(this.status_bar);
			this.Controls.Add(this.main_menu);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.main_menu;
			this.MinimumSize = new System.Drawing.Size(815, 509);
			this.Name = "BankLab";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "BankLab";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankLab_FormClosing);
			this.ResizeBegin += new System.EventHandler(this.BankLab_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.BankLab_ResizeEnd);
			this.Resize += new System.EventHandler(this.BankLab_Resize);
			this.status_bar.ResumeLayout(false);
			this.status_bar.PerformLayout();
			this.main_menu.ResumeLayout(false);
			this.main_menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.StatusStrip status_bar;
        private System.Windows.Forms.ToolStripProgressBar toolstrip_progressbar;
		private System.Windows.Forms.ToolStripStatusLabel toolstrip_label;
        private System.Windows.Forms.Panel sidebar_panel;
		private System.Windows.Forms.Splitter sidebar_splitter;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закрыть_back;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem изменитьИнтервал_back;
		private System.Windows.Forms.ToolStripMenuItem изменитьИнтервалToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem показатьСкрытьБоковуюПанельToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem формыКоэффициентовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиПрограммыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem диспетчерБазыДанныхToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.MenuStrip main_menu;
		private System.Windows.Forms.ToolStripMenuItem сохранить_back;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранить_какBack;
		private System.Windows.Forms.ToolStripMenuItem дествиеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem прогнозированиеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оптимизацияToolStripMenuItem;
    }
}