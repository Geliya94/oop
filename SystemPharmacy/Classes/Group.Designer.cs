namespace SystemPharmacy
{
    partial class Group
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
            this.BTN_add = new System.Windows.Forms.Button();
            this.BTN_upd = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.GroupTableAdapter();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
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
            this.idgroupDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.groupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(12, 174);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(75, 23);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(103, 174);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(75, 23);
            this.BTN_upd.TabIndex = 2;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(193, 174);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(75, 23);
            this.BTN_del.TabIndex = 3;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.myDBDataSet;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
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
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(521, 209);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_upd);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Group";
            this.Text = "Group";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.Button BTN_del;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private MyDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}