namespace SystemPharmacy
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gB2 = new System.Windows.Forms.GroupBox();
            this.BTN_schet = new System.Windows.Forms.Button();
            this.BTN_zakaz = new System.Windows.Forms.Button();
            this.BTN_zakupki = new System.Windows.Forms.Button();
            this.BTN_otchet = new System.Windows.Forms.Button();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritm_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.card_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.setup_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.postavchik_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.group_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.preparat_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.button_sale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idpreparatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalDGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nalDGVTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.NalDGVTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.gB2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalDGVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gB2
            // 
            this.gB2.Controls.Add(this.BTN_schet);
            this.gB2.Controls.Add(this.BTN_zakaz);
            this.gB2.Controls.Add(this.BTN_zakupki);
            this.gB2.Controls.Add(this.BTN_otchet);
            this.gB2.Location = new System.Drawing.Point(12, 252);
            this.gB2.Name = "gB2";
            this.gB2.Size = new System.Drawing.Size(234, 237);
            this.gB2.TabIndex = 1;
            this.gB2.TabStop = false;
            this.gB2.Text = "Действия";
            // 
            // BTN_schet
            // 
            this.BTN_schet.Location = new System.Drawing.Point(19, 170);
            this.BTN_schet.Name = "BTN_schet";
            this.BTN_schet.Size = new System.Drawing.Size(196, 38);
            this.BTN_schet.TabIndex = 8;
            this.BTN_schet.Text = "Сформировать счета";
            this.BTN_schet.UseVisualStyleBackColor = true;
            this.BTN_schet.Click += new System.EventHandler(this.BTN_schet_Click);
            // 
            // BTN_zakaz
            // 
            this.BTN_zakaz.Location = new System.Drawing.Point(19, 19);
            this.BTN_zakaz.Name = "BTN_zakaz";
            this.BTN_zakaz.Size = new System.Drawing.Size(196, 38);
            this.BTN_zakaz.TabIndex = 7;
            this.BTN_zakaz.Text = "Сформировать заказ";
            this.BTN_zakaz.UseVisualStyleBackColor = true;
            this.BTN_zakaz.Click += new System.EventHandler(this.BTN_zakaz_Click);
            // 
            // BTN_zakupki
            // 
            this.BTN_zakupki.Location = new System.Drawing.Point(19, 72);
            this.BTN_zakupki.Name = "BTN_zakupki";
            this.BTN_zakupki.Size = new System.Drawing.Size(196, 38);
            this.BTN_zakupki.TabIndex = 6;
            this.BTN_zakupki.Text = "Загрузить закупки";
            this.BTN_zakupki.UseVisualStyleBackColor = true;
            
            // 
            // BTN_otchet
            // 
            this.BTN_otchet.Location = new System.Drawing.Point(19, 126);
            this.BTN_otchet.Name = "BTN_otchet";
            this.BTN_otchet.Size = new System.Drawing.Size(196, 38);
            this.BTN_otchet.TabIndex = 5;
            this.BTN_otchet.Text = "Сформировать отчет";
            this.BTN_otchet.UseVisualStyleBackColor = true;
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(400, 29);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(132, 20);
            this.tBSearch.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritm_menu,
            this.card_menu,
            this.setup_menu,
            this.postavchik_menu,
            this.group_menu,
            this.preparat_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritm_menu
            // 
            this.algoritm_menu.Name = "algoritm_menu";
            this.algoritm_menu.Size = new System.Drawing.Size(140, 20);
            this.algoritm_menu.Text = "Настройка алгоритма";
            this.algoritm_menu.Click += new System.EventHandler(this.algoritm_menu_Click_1);
            // 
            // card_menu
            // 
            this.card_menu.Name = "card_menu";
            this.card_menu.Size = new System.Drawing.Size(182, 20);
            this.card_menu.Text = "Настройка дисконтной карты";
            this.card_menu.Click += new System.EventHandler(this.card_menu_Click_1);
            // 
            // setup_menu
            // 
            this.setup_menu.Name = "setup_menu";
            this.setup_menu.Size = new System.Drawing.Size(197, 20);
            this.setup_menu.Text = "Установка порогового значения";
            this.setup_menu.Click += new System.EventHandler(this.setup_menu_Click);
            // 
            // postavchik_menu
            // 
            this.postavchik_menu.Name = "postavchik_menu";
            this.postavchik_menu.Size = new System.Drawing.Size(82, 20);
            this.postavchik_menu.Text = "Поставщик";
            this.postavchik_menu.Click += new System.EventHandler(this.postavchik_menu_Click);
            // 
            // group_menu
            // 
            this.group_menu.Name = "group_menu";
            this.group_menu.Size = new System.Drawing.Size(110, 20);
            this.group_menu.Text = "Группа лекарств";
            this.group_menu.Click += new System.EventHandler(this.group_menu_Click);
            // 
            // preparat_menu
            // 
            this.preparat_menu.Name = "preparat_menu";
            this.preparat_menu.Size = new System.Drawing.Size(191, 20);
            this.preparat_menu.Text = "Настройка данных о препарате";
            this.preparat_menu.Click += new System.EventHandler(this.preparat_menu_Click);
            // 
            // button_sale
            // 
            this.button_sale.Location = new System.Drawing.Point(622, 408);
            this.button_sale.Name = "button_sale";
            this.button_sale.Size = new System.Drawing.Size(120, 23);
            this.button_sale.TabIndex = 7;
            this.button_sale.Text = "Совершить продажу";
            this.button_sale.UseVisualStyleBackColor = true;
            this.button_sale.Click += new System.EventHandler(this.button_sale_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите препарат";
            // 
            // BTN_search
            // 
            this.BTN_search.Location = new System.Drawing.Point(572, 27);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(75, 23);
            this.BTN_search.TabIndex = 9;
            this.BTN_search.Text = "Поиск";
            this.BTN_search.UseVisualStyleBackColor = true;
            this.BTN_search.Click += new System.EventHandler(this.BTN_search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(635, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(272, 224);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(664, 138);
            this.dataGridView2.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Препарат";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Пересч.сумма";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.monthCalendar1.Location = new System.Drawing.Point(31, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpreparatDataGridViewTextBoxColumn,
            this.idgroupDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gROUPNAMEDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.srokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nalDGVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(272, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 158);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idpreparatDataGridViewTextBoxColumn
            // 
            this.idpreparatDataGridViewTextBoxColumn.DataPropertyName = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.HeaderText = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.Name = "idpreparatDataGridViewTextBoxColumn";
            this.idpreparatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpreparatDataGridViewTextBoxColumn.Visible = false;
            // 
            // idgroupDataGridViewTextBoxColumn
            // 
            this.idgroupDataGridViewTextBoxColumn.DataPropertyName = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgroupDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gROUPNAMEDataGridViewTextBoxColumn
            // 
            this.gROUPNAMEDataGridViewTextBoxColumn.DataPropertyName = "GROUPNAME";
            this.gROUPNAMEDataGridViewTextBoxColumn.HeaderText = "GROUPNAME";
            this.gROUPNAMEDataGridViewTextBoxColumn.Name = "gROUPNAMEDataGridViewTextBoxColumn";
            this.gROUPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srokDataGridViewTextBoxColumn
            // 
            this.srokDataGridViewTextBoxColumn.DataPropertyName = "Srok";
            this.srokDataGridViewTextBoxColumn.HeaderText = "Srok";
            this.srokDataGridViewTextBoxColumn.Name = "srokDataGridViewTextBoxColumn";
            this.srokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nalDGVBindingSource
            // 
            this.nalDGVBindingSource.DataMember = "NalDGV";
            this.nalDGVBindingSource.DataSource = this.myDBDataSet;
            // 
            // nalDGVTableAdapter
            // 
            this.nalDGVTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Введите № карты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сумма ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Пересчитанная сумма";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(400, 444);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(520, 408);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 21;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 490);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sale);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.gB2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nalDGVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB2;
        private System.Windows.Forms.Button BTN_schet;
        private System.Windows.Forms.Button BTN_zakaz;
        private System.Windows.Forms.Button BTN_zakupki;
        private System.Windows.Forms.Button BTN_otchet;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritm_menu;
        private System.Windows.Forms.ToolStripMenuItem card_menu;
        private System.Windows.Forms.ToolStripMenuItem setup_menu;
        private System.Windows.Forms.ToolStripMenuItem postavchik_menu;
        private System.Windows.Forms.ToolStripMenuItem group_menu;
        private System.Windows.Forms.Button button_sale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem preparat_menu;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpreparatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BTN_OK;
        public System.Windows.Forms.BindingSource nalDGVBindingSource;
        public MyDBDataSetTableAdapters.NalDGVTableAdapter nalDGVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

