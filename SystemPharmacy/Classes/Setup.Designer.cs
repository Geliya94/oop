namespace SystemPharmacy
{
    partial class Setup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsetupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.BTN_upd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_del1 = new System.Windows.Forms.Button();
            this.BTN_add1 = new System.Windows.Forms.Button();
            this.DTN_upd1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.setupTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.SetupTableAdapter();
            this.preparSetDGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparSetDGVTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PreparSetDGVTableAdapter();
            this.idpreparatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsetupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porogDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparSetDGVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsetupDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.porogDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.setupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(486, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // idsetupDataGridViewTextBoxColumn
            // 
            this.idsetupDataGridViewTextBoxColumn.DataPropertyName = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.HeaderText = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.Name = "idsetupDataGridViewTextBoxColumn";
            this.idsetupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porogDataGridViewTextBoxColumn
            // 
            this.porogDataGridViewTextBoxColumn.DataPropertyName = "Porog";
            this.porogDataGridViewTextBoxColumn.HeaderText = "Porog";
            this.porogDataGridViewTextBoxColumn.Name = "porogDataGridViewTextBoxColumn";
            this.porogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "Setup";
            this.setupBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(192, 186);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(76, 23);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(413, 186);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(76, 23);
            this.BTN_del.TabIndex = 2;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(300, 186);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(76, 23);
            this.BTN_upd.TabIndex = 3;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 262);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.BTN_del);
            this.tabPage1.Controls.Add(this.BTN_add);
            this.tabPage1.Controls.Add(this.BTN_upd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Настройка порогового значения";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.BTN_del1);
            this.tabPage2.Controls.Add(this.BTN_add1);
            this.tabPage2.Controls.Add(this.DTN_upd1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройка порога таблеток";
            // 
            // BTN_del1
            // 
            this.BTN_del1.Location = new System.Drawing.Point(407, 192);
            this.BTN_del1.Name = "BTN_del1";
            this.BTN_del1.Size = new System.Drawing.Size(76, 23);
            this.BTN_del1.TabIndex = 5;
            this.BTN_del1.Text = "Удалить";
            this.BTN_del1.UseVisualStyleBackColor = true;
            this.BTN_del1.Click += new System.EventHandler(this.BTN_del1_Click);
            // 
            // BTN_add1
            // 
            this.BTN_add1.Location = new System.Drawing.Point(186, 192);
            this.BTN_add1.Name = "BTN_add1";
            this.BTN_add1.Size = new System.Drawing.Size(76, 23);
            this.BTN_add1.TabIndex = 4;
            this.BTN_add1.Text = "Добавить";
            this.BTN_add1.UseVisualStyleBackColor = true;
            this.BTN_add1.Click += new System.EventHandler(this.BTN_add1_Click);
            // 
            // DTN_upd1
            // 
            this.DTN_upd1.Location = new System.Drawing.Point(294, 192);
            this.DTN_upd1.Name = "DTN_upd1";
            this.DTN_upd1.Size = new System.Drawing.Size(76, 23);
            this.DTN_upd1.TabIndex = 6;
            this.DTN_upd1.Text = "Изменить";
            this.DTN_upd1.UseVisualStyleBackColor = true;
            this.DTN_upd1.Click += new System.EventHandler(this.DTN_upd1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpreparatDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.idsetupDataGridViewTextBoxColumn1,
            this.porogDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.preparSetDGVBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(489, 186);
            this.dataGridView2.TabIndex = 0;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // preparSetDGVBindingSource
            // 
            this.preparSetDGVBindingSource.DataMember = "PreparSetDGV";
            this.preparSetDGVBindingSource.DataSource = this.myDBDataSet;
            // 
            // preparSetDGVTableAdapter
            // 
            this.preparSetDGVTableAdapter.ClearBeforeFill = true;
            // 
            // idpreparatDataGridViewTextBoxColumn
            // 
            this.idpreparatDataGridViewTextBoxColumn.DataPropertyName = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.HeaderText = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.Name = "idpreparatDataGridViewTextBoxColumn";
            this.idpreparatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idsetupDataGridViewTextBoxColumn1
            // 
            this.idsetupDataGridViewTextBoxColumn1.DataPropertyName = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn1.HeaderText = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn1.Name = "idsetupDataGridViewTextBoxColumn1";
            this.idsetupDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // porogDataGridViewTextBoxColumn1
            // 
            this.porogDataGridViewTextBoxColumn1.DataPropertyName = "Porog";
            this.porogDataGridViewTextBoxColumn1.HeaderText = "Porog";
            this.porogDataGridViewTextBoxColumn1.Name = "porogDataGridViewTextBoxColumn1";
            this.porogDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(512, 271);
            this.Controls.Add(this.tabControl1);
            this.Name = "Setup";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparSetDGVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_del1;
        private System.Windows.Forms.Button BTN_add1;
        private System.Windows.Forms.Button DTN_upd1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private MyDBDataSetTableAdapters.SetupTableAdapter setupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsetupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porogDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource preparSetDGVBindingSource;
        private MyDBDataSetTableAdapters.PreparSetDGVTableAdapter preparSetDGVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpreparatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsetupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn porogDataGridViewTextBoxColumn1;
    }
}