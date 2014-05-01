namespace SystemPharmacy
{
    partial class ADD_Preparat
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BTN_ok = new System.Windows.Forms.Button();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.preparatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preparatTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PreparatTableAdapter();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PostavchikTableAdapter();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.SetupTableAdapter();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.GroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.preparatBindingSource, "Id_postavchik", true));
            this.comboBox1.DataSource = this.postavchikBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id_postavchik";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.preparatBindingSource, "Id_setup", true));
            this.comboBox2.DataSource = this.setupBindingSource;
            this.comboBox2.DisplayMember = "Porog";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Id_setup";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparatBindingSource, "Name", true));
            this.textBox2.Location = new System.Drawing.Point(239, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparatBindingSource, "Price", true));
            this.textBox3.Location = new System.Drawing.Point(239, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 4;
            // 
            // BTN_ok
            // 
            this.BTN_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_ok.Location = new System.Drawing.Point(190, 288);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_ok.TabIndex = 5;
            this.BTN_ok.Text = "OK";
            this.BTN_ok.UseVisualStyleBackColor = true;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancel.Location = new System.Drawing.Point(295, 288);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_cancel.TabIndex = 6;
            this.BTN_cancel.Text = "CANCEL";
            this.BTN_cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите  цену";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите настройку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Выберите   группу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите срок годности";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Введите количество";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparatBindingSource, "Amount", true));
            this.textBox1.Location = new System.Drawing.Point(239, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.preparatBindingSource, "Srok", true));
            this.textBox4.Location = new System.Drawing.Point(239, 232);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.preparatBindingSource, "Id_group", true));
            this.comboBox3.DataSource = this.groupBindingSource;
            this.comboBox3.DisplayMember = "Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(239, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.ValueMember = "Id_group";
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
            // postavchikBindingSource
            // 
            this.postavchikBindingSource.DataMember = "Postavchik";
            this.postavchikBindingSource.DataSource = this.myDBDataSet;
            // 
            // postavchikTableAdapter
            // 
            this.postavchikTableAdapter.ClearBeforeFill = true;
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "Setup";
            this.setupBindingSource.DataSource = this.myDBDataSet;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
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
            // ADD_Preparat
            // 
            this.AcceptButton = this.BTN_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.BTN_cancel;
            this.ClientSize = new System.Drawing.Size(443, 323);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ADD_Preparat";
            this.Text = "ADD_Preparat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADD_Preparat_FormClosing);
            this.Load += new System.EventHandler(this.ADD_Preparat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preparatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private MyDBDataSet myDBDataSet;
        private MyDBDataSetTableAdapters.PreparatTableAdapter preparatTableAdapter;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private MyDBDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private MyDBDataSetTableAdapters.SetupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private MyDBDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        public System.Windows.Forms.BindingSource preparatBindingSource;
    }
}