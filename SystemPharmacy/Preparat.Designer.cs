namespace SystemPharmacy
{
    partial class Preparat
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
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.preparatDGVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparatDGVTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.preparatDGVTableAdapter();
            this.idpreparatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpostavchikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsetupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETUPPOROgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_UPD = new System.Windows.Forms.Button();
            this.BTN_DEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatDGVBindingSource)).BeginInit();
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
            this.idpreparatDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pOSTNAMEDataGridViewTextBoxColumn,
            this.gROUPNAMEDataGridViewTextBoxColumn,
            this.idpostavchikDataGridViewTextBoxColumn,
            this.idsetupDataGridViewTextBoxColumn,
            this.idgroupDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.srokDataGridViewTextBoxColumn,
            this.sETUPPOROgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.preparatDGVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // preparatDGVBindingSource
            // 
            this.preparatDGVBindingSource.DataMember = "preparatDGV";
            this.preparatDGVBindingSource.DataSource = this.myDBDataSet;
            // 
            // preparatDGVTableAdapter
            // 
            this.preparatDGVTableAdapter.ClearBeforeFill = true;
            // 
            // idpreparatDataGridViewTextBoxColumn
            // 
            this.idpreparatDataGridViewTextBoxColumn.DataPropertyName = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.HeaderText = "Id_preparat";
            this.idpreparatDataGridViewTextBoxColumn.Name = "idpreparatDataGridViewTextBoxColumn";
            this.idpreparatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSTNAMEDataGridViewTextBoxColumn
            // 
            this.pOSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "POSTNAME";
            this.pOSTNAMEDataGridViewTextBoxColumn.HeaderText = "POSTNAME";
            this.pOSTNAMEDataGridViewTextBoxColumn.Name = "pOSTNAMEDataGridViewTextBoxColumn";
            this.pOSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gROUPNAMEDataGridViewTextBoxColumn
            // 
            this.gROUPNAMEDataGridViewTextBoxColumn.DataPropertyName = "GROUPNAME";
            this.gROUPNAMEDataGridViewTextBoxColumn.HeaderText = "GROUPNAME";
            this.gROUPNAMEDataGridViewTextBoxColumn.Name = "gROUPNAMEDataGridViewTextBoxColumn";
            this.gROUPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpostavchikDataGridViewTextBoxColumn
            // 
            this.idpostavchikDataGridViewTextBoxColumn.DataPropertyName = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.HeaderText = "Id_postavchik";
            this.idpostavchikDataGridViewTextBoxColumn.Name = "idpostavchikDataGridViewTextBoxColumn";
            this.idpostavchikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpostavchikDataGridViewTextBoxColumn.Visible = false;
            // 
            // idsetupDataGridViewTextBoxColumn
            // 
            this.idsetupDataGridViewTextBoxColumn.DataPropertyName = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.HeaderText = "Id_setup";
            this.idsetupDataGridViewTextBoxColumn.Name = "idsetupDataGridViewTextBoxColumn";
            this.idsetupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsetupDataGridViewTextBoxColumn.Visible = false;
            // 
            // idgroupDataGridViewTextBoxColumn
            // 
            this.idgroupDataGridViewTextBoxColumn.DataPropertyName = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.HeaderText = "Id_group";
            this.idgroupDataGridViewTextBoxColumn.Name = "idgroupDataGridViewTextBoxColumn";
            this.idgroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgroupDataGridViewTextBoxColumn.Visible = false;
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
            // sETUPPOROgDataGridViewTextBoxColumn
            // 
            this.sETUPPOROgDataGridViewTextBoxColumn.DataPropertyName = "SETUPPOROg";
            this.sETUPPOROgDataGridViewTextBoxColumn.HeaderText = "SETUPPOROg";
            this.sETUPPOROgDataGridViewTextBoxColumn.Name = "sETUPPOROgDataGridViewTextBoxColumn";
            this.sETUPPOROgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(12, 197);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(75, 23);
            this.BTN_ADD.TabIndex = 1;
            this.BTN_ADD.Text = "Добавить";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_UPD
            // 
            this.BTN_UPD.Location = new System.Drawing.Point(139, 197);
            this.BTN_UPD.Name = "BTN_UPD";
            this.BTN_UPD.Size = new System.Drawing.Size(75, 23);
            this.BTN_UPD.TabIndex = 2;
            this.BTN_UPD.Text = "Изменить";
            this.BTN_UPD.UseVisualStyleBackColor = true;
            this.BTN_UPD.Click += new System.EventHandler(this.BTN_UPD_Click);
            // 
            // BTN_DEL
            // 
            this.BTN_DEL.Location = new System.Drawing.Point(257, 197);
            this.BTN_DEL.Name = "BTN_DEL";
            this.BTN_DEL.Size = new System.Drawing.Size(75, 23);
            this.BTN_DEL.TabIndex = 3;
            this.BTN_DEL.Text = "Удалить";
            this.BTN_DEL.UseVisualStyleBackColor = false;
            this.BTN_DEL.Click += new System.EventHandler(this.BTN_DEL_Click);
            // 
            // Preparat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 232);
            this.Controls.Add(this.BTN_DEL);
            this.Controls.Add(this.BTN_UPD);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Preparat";
            this.Text = "Preparat";
            this.Load += new System.EventHandler(this.Preparat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatDGVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource preparatDGVBindingSource;
        private MyDBDataSetTableAdapters.preparatDGVTableAdapter preparatDGVTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpreparatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gROUPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpostavchikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsetupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETUPPOROgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_UPD;
        private System.Windows.Forms.Button BTN_DEL;
    }
}