namespace SystemPharmacy
{
    partial class Postavchik
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
            this.BTN_upd = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PostavchikTableAdapter();
            this.idpostavchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
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
            this.idpostavchikDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavchikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(588, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(426, 197);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(74, 23);
            this.BTN_upd.TabIndex = 6;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(515, 197);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(74, 23);
            this.BTN_del.TabIndex = 5;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(334, 197);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(74, 23);
            this.BTN_add.TabIndex = 4;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.myDBDataSet;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // idpostavchikDataGridViewTextBoxColumn
            // 
            this.idpostavchikDataGridViewTextBoxColumn.DataPropertyName = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.HeaderText = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.Name = "idpostavchikDataGridViewTextBoxColumn";
            this.idpostavchikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Postavchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(601, 232);
            this.Controls.Add(this.BTN_upd);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Postavchik";
            this.Text = "Postavchik";
            this.Load += new System.EventHandler(this.Postavchik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.Button BTN_add;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private MyDBDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostavchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}