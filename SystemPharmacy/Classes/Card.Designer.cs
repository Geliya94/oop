namespace SystemPharmacy
{
    partial class Card
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
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_upd = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardDGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.cardDGVTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.cardDGVTableAdapter();
            this.idcardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalgoritmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summanakoplDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentprocentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieAlgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDGVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(209, 207);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(76, 21);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(291, 207);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(76, 21);
            this.BTN_upd.TabIndex = 2;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(384, 207);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(76, 21);
            this.BTN_del.TabIndex = 3;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcardDataGridViewTextBoxColumn,
            this.idalgoritmDataGridViewTextBoxColumn,
            this.summanakoplDataGridViewTextBoxColumn,
            this.currentprocentDataGridViewTextBoxColumn,
            this.nazvanieAlgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cardDGVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // cardDGVBindingSource
            // 
            this.cardDGVBindingSource.DataMember = "cardDGV";
            this.cardDGVBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardDGVTableAdapter
            // 
            this.cardDGVTableAdapter.ClearBeforeFill = true;
            // 
            // idcardDataGridViewTextBoxColumn
            // 
            this.idcardDataGridViewTextBoxColumn.DataPropertyName = "Id_card";
            this.idcardDataGridViewTextBoxColumn.HeaderText = "Id_card";
            this.idcardDataGridViewTextBoxColumn.Name = "idcardDataGridViewTextBoxColumn";
            this.idcardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idalgoritmDataGridViewTextBoxColumn
            // 
            this.idalgoritmDataGridViewTextBoxColumn.DataPropertyName = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn.HeaderText = "Id_algoritm";
            this.idalgoritmDataGridViewTextBoxColumn.Name = "idalgoritmDataGridViewTextBoxColumn";
            this.idalgoritmDataGridViewTextBoxColumn.ReadOnly = true;
            this.idalgoritmDataGridViewTextBoxColumn.Visible = false;
            // 
            // summanakoplDataGridViewTextBoxColumn
            // 
            this.summanakoplDataGridViewTextBoxColumn.DataPropertyName = "Summa_nakopl";
            this.summanakoplDataGridViewTextBoxColumn.HeaderText = "Summa_nakopl";
            this.summanakoplDataGridViewTextBoxColumn.Name = "summanakoplDataGridViewTextBoxColumn";
            this.summanakoplDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentprocentDataGridViewTextBoxColumn
            // 
            this.currentprocentDataGridViewTextBoxColumn.DataPropertyName = "Current_procent";
            this.currentprocentDataGridViewTextBoxColumn.HeaderText = "Current_procent";
            this.currentprocentDataGridViewTextBoxColumn.Name = "currentprocentDataGridViewTextBoxColumn";
            this.currentprocentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazvanieAlgDataGridViewTextBoxColumn
            // 
            this.nazvanieAlgDataGridViewTextBoxColumn.DataPropertyName = "NazvanieAlg";
            this.nazvanieAlgDataGridViewTextBoxColumn.HeaderText = "NazvanieAlg";
            this.nazvanieAlgDataGridViewTextBoxColumn.Name = "nazvanieAlgDataGridViewTextBoxColumn";
            this.nazvanieAlgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(472, 240);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_upd);
            this.Controls.Add(this.BTN_add);
            this.Name = "Card";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDGVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.Button BTN_del;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource cardDGVBindingSource;
        private MyDBDataSetTableAdapters.cardDGVTableAdapter cardDGVTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalgoritmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summanakoplDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentprocentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieAlgDataGridViewTextBoxColumn;
        //   private MyDBDataSetTableAdapters.Algoritm_CardTableAdapter algoritm_CardTableAdapter;
    }
}