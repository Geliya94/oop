namespace SystemPharmacy
{
    partial class ADD_svyaz
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_OK1 = new System.Windows.Forms.Button();
            this.BTN_CANCEL1 = new System.Windows.Forms.Button();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.discountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.DiscountTableAdapter();
            this.algoritmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.algoritmTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.AlgoritmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoritmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.discountBindingSource, "Id_algoritm", true));
            this.comboBox1.DataSource = this.algoritmBindingSource;
            this.comboBox1.DisplayMember = "Nazvanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id_algoritm";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.discountBindingSource, "Summa", true));
            this.textBox1.Location = new System.Drawing.Point(237, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.discountBindingSource, "Procent", true));
            this.textBox2.Location = new System.Drawing.Point(237, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите алгоритм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите сумму";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите соотвествующий процент";
            // 
            // BTN_OK1
            // 
            this.BTN_OK1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK1.Location = new System.Drawing.Point(144, 120);
            this.BTN_OK1.Name = "BTN_OK1";
            this.BTN_OK1.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK1.TabIndex = 6;
            this.BTN_OK1.Text = "OK";
            this.BTN_OK1.UseVisualStyleBackColor = true;
            // 
            // BTN_CANCEL1
            // 
            this.BTN_CANCEL1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_CANCEL1.Location = new System.Drawing.Point(237, 120);
            this.BTN_CANCEL1.Name = "BTN_CANCEL1";
            this.BTN_CANCEL1.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCEL1.TabIndex = 7;
            this.BTN_CANCEL1.Text = "CANCEL";
            this.BTN_CANCEL1.UseVisualStyleBackColor = true;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountBindingSource
            // 
            this.discountBindingSource.DataMember = "Discount";
            this.discountBindingSource.DataSource = this.myDBDataSet;
            // 
            // discountTableAdapter
            // 
            this.discountTableAdapter.ClearBeforeFill = true;
            // 
            // algoritmBindingSource
            // 
            this.algoritmBindingSource.DataMember = "Algoritm";
            this.algoritmBindingSource.DataSource = this.myDBDataSet;
            // 
            // algoritmTableAdapter
            // 
            this.algoritmTableAdapter.ClearBeforeFill = true;
            // 
            // ADD_svyaz
            // 
            this.AcceptButton = this.BTN_OK1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_CANCEL1;
            this.ClientSize = new System.Drawing.Size(370, 173);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_CANCEL1);
            this.Controls.Add(this.BTN_OK1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ADD_svyaz";
            this.Text = "ADD_svyaz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADD_svyaz_FormClosing);
            this.Load += new System.EventHandler(this.ADD_svyaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.algoritmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_OK1;
        private System.Windows.Forms.Button BTN_CANCEL1;
        private MyDBDataSet myDBDataSet;
        private MyDBDataSetTableAdapters.DiscountTableAdapter discountTableAdapter;
        public System.Windows.Forms.BindingSource discountBindingSource;
        private System.Windows.Forms.BindingSource algoritmBindingSource;
        private MyDBDataSetTableAdapters.AlgoritmTableAdapter algoritmTableAdapter;
      
       // private System.Windows.Forms.BindingSource algoritmBindingSource;

      //  public System.Windows.Forms.BindingSource discountBindingSource;
    }
}