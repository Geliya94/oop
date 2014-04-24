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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.BTN_sale = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritm_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.card_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.setup_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.postavchik_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.group_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.preparatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparatTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PreparatTableAdapter();
            this.idpreparatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostavchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsetupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatBindingSource)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpreparatDataGridViewTextBoxColumn,
            this.idpostavchikDataGridViewTextBoxColumn,
            this.idsetupDataGridViewTextBoxColumn,
            this.idgroupDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.srokDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.preparatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(272, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(664, 241);
            this.dataGridView1.TabIndex = 2;
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(617, 25);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(132, 20);
            this.tBSearch.TabIndex = 3;
            // 
            // BTN_sale
            // 
            this.BTN_sale.Location = new System.Drawing.Point(861, 393);
            this.BTN_sale.Name = "BTN_sale";
            this.BTN_sale.Size = new System.Drawing.Size(75, 23);
            this.BTN_sale.TabIndex = 4;
            this.BTN_sale.Text = "Продать";
            this.BTN_sale.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritm_menu,
            this.card_menu,
            this.setup_menu,
            this.postavchik_menu,
            this.group_menu});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preparatBindingSource
            // 
            this.preparatBindingSource.DataMember = "Preparat";
            this.preparatBindingSource.DataSource = this.myDBDataSet;
            // 
            // preparatTableAdapter
            // 
            this.preparatTableAdapter.ClearBeforeFill = true;
            // 
            // idpreparatDataGridViewTextBoxColumn
            // 
            this.idpreparatDataGridViewTextBoxColumn.DataPropertyName = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.HeaderText = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.Name = "idpreparatDataGridViewTextBoxColumn";
            this.idpreparatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpostavchikDataGridViewTextBoxColumn
            // 
            this.idpostavchikDataGridViewTextBoxColumn.DataPropertyName = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.HeaderText = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.Name = "idpostavchikDataGridViewTextBoxColumn";
            this.idpostavchikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idsetupDataGridViewTextBoxColumn
            // 
            this.idsetupDataGridViewTextBoxColumn.DataPropertyName = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.HeaderText = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.Name = "idsetupDataGridViewTextBoxColumn";
            this.idsetupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idgroupDataGridViewTextBoxColumn
            // 
            this.idgroupDataGridViewTextBoxColumn.DataPropertyName = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_sale);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gB2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gB2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gB2;
        private System.Windows.Forms.Button BTN_schet;
        private System.Windows.Forms.Button BTN_zakaz;
        private System.Windows.Forms.Button BTN_zakupki;
        private System.Windows.Forms.Button BTN_otchet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button BTN_sale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritm_menu;
        private System.Windows.Forms.ToolStripMenuItem card_menu;
        private System.Windows.Forms.ToolStripMenuItem setup_menu;
        private System.Windows.Forms.ToolStripMenuItem postavchik_menu;
        private System.Windows.Forms.ToolStripMenuItem group_menu;
        private System.Windows.Forms.Button button1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource preparatBindingSource;
        private MyDBDataSetTableAdapters.PreparatTableAdapter preparatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpreparatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostavchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsetupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
    }
}

