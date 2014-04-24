namespace SystemPharmacy
{
    partial class Algoritm
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
            this.BTN_add1 = new System.Windows.Forms.Button();
            this.BTN_upd1 = new System.Windows.Forms.Button();
            this.BTN_del1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_upd = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idalgoritmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algoritmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.algoritmTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.AlgoritmTableAdapter();
            this.discountDGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountDGVTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.DiscountDGVTableAdapter();
            this.nazvanieAlgoritmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalgoritmDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoritmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountDGVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_add1
            // 
            this.BTN_add1.Location = new System.Drawing.Point(280, 234);
            this.BTN_add1.Name = "BTN_add1";
            this.BTN_add1.Size = new System.Drawing.Size(75, 23);
            this.BTN_add1.TabIndex = 1;
            this.BTN_add1.Text = "Добавить";
            this.BTN_add1.UseVisualStyleBackColor = true;
            this.BTN_add1.Click += new System.EventHandler(this.BTN_add1_Click);
            // 
            // BTN_upd1
            // 
            this.BTN_upd1.Location = new System.Drawing.Point(374, 234);
            this.BTN_upd1.Name = "BTN_upd1";
            this.BTN_upd1.Size = new System.Drawing.Size(75, 23);
            this.BTN_upd1.TabIndex = 2;
            this.BTN_upd1.Text = "Изменить";
            this.BTN_upd1.UseVisualStyleBackColor = true;
            this.BTN_upd1.Click += new System.EventHandler(this.BTN_upd1_Click);
            // 
            // BTN_del1
            // 
            this.BTN_del1.Location = new System.Drawing.Point(473, 234);
            this.BTN_del1.Name = "BTN_del1";
            this.BTN_del1.Size = new System.Drawing.Size(75, 23);
            this.BTN_del1.TabIndex = 3;
            this.BTN_del1.Text = "Удалить";
            this.BTN_del1.UseVisualStyleBackColor = true;
            this.BTN_del1.Click += new System.EventHandler(this.BTN_del1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 294);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BTN_add);
            this.tabPage1.Controls.Add(this.BTN_upd);
            this.tabPage1.Controls.Add(this.BTN_del);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка алгоритма";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalgoritmDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.algoritmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(551, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(247, 238);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(79, 24);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(354, 238);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(74, 24);
            this.BTN_upd.TabIndex = 2;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(454, 238);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(73, 24);
            this.BTN_del.TabIndex = 3;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.BTN_del1);
            this.tabPage2.Controls.Add(this.BTN_upd1);
            this.tabPage2.Controls.Add(this.BTN_add1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Установление скидки";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazvanieAlgoritmDataGridViewTextBoxColumn,
            this.iddiscountDataGridViewTextBoxColumn,
            this.idalgoritmDataGridViewTextBoxColumn1,
            this.summaDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.discountDGVBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(545, 225);
            this.dataGridView2.TabIndex = 0;
            // 
            // idalgoritmDataGridViewTextBoxColumn
            // 
            this.idalgoritmDataGridViewTextBoxColumn.DataPropertyName = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn.HeaderText = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn.Name = "idalgoritmDataGridViewTextBoxColumn";
            this.idalgoritmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // algoritmBindingSource
            // 
            this.algoritmBindingSource.DataMember = "Algoritm";
            this.algoritmBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // algoritmTableAdapter
            // 
            this.algoritmTableAdapter.ClearBeforeFill = true;
            // 
            // discountDGVBindingSource
            // 
            this.discountDGVBindingSource.DataMember = "DiscountDGV";
            this.discountDGVBindingSource.DataSource = this.myDBDataSet;
            // 
            // discountDGVTableAdapter
            // 
            this.discountDGVTableAdapter.ClearBeforeFill = true;
            // 
            // nazvanieAlgoritmDataGridViewTextBoxColumn
            // 
            this.nazvanieAlgoritmDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie_Algoritm";
            this.nazvanieAlgoritmDataGridViewTextBoxColumn.HeaderText = "Nazvanie_Algoritm";
            this.nazvanieAlgoritmDataGridViewTextBoxColumn.Name = "nazvanieAlgoritmDataGridViewTextBoxColumn";
            this.nazvanieAlgoritmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddiscountDataGridViewTextBoxColumn
            // 
            this.iddiscountDataGridViewTextBoxColumn.DataPropertyName = "Id_discount";
            this.iddiscountDataGridViewTextBoxColumn.HeaderText = "Id_discount";
            this.iddiscountDataGridViewTextBoxColumn.Name = "iddiscountDataGridViewTextBoxColumn";
            this.iddiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idalgoritmDataGridViewTextBoxColumn1
            // 
            this.idalgoritmDataGridViewTextBoxColumn1.DataPropertyName = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn1.HeaderText = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn1.Name = "idalgoritmDataGridViewTextBoxColumn1";
            this.idalgoritmDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            this.summaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Algoritm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "Algoritm";
            this.Text = "Algoritm";
            this.Load += new System.EventHandler(this.Algoritm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoritmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountDGVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTN_add1;
        private System.Windows.Forms.Button BTN_upd1;
        private System.Windows.Forms.Button BTN_del1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource algoritmBindingSource;
        private MyDBDataSetTableAdapters.AlgoritmTableAdapter algoritmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalgoritmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource discountDGVBindingSource;
        private MyDBDataSetTableAdapters.DiscountDGVTableAdapter discountDGVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieAlgoritmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalgoritmDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
    }
}