namespace SystemPharmacy
{
    partial class ADD_Postavchik
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
            this.BTN_ok = new System.Windows.Forms.Button();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PostavchikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ok
            // 
            this.BTN_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_ok.Location = new System.Drawing.Point(325, 106);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(74, 21);
            this.BTN_ok.TabIndex = 0;
            this.BTN_ok.Text = "OK";
            this.BTN_ok.UseVisualStyleBackColor = true;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancel.Location = new System.Drawing.Point(405, 106);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(74, 21);
            this.BTN_cancel.TabIndex = 1;
            this.BTN_cancel.Text = "CANCEL";
            this.BTN_cancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavchikBindingSource, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(227, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavchikBindingSource, "Address", true));
            this.textBox2.Location = new System.Drawing.Point(227, 65);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postavchikBindingSource, "Email", true));
            this.textBox3.Location = new System.Drawing.Point(227, 38);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 21);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование поставщика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес";
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
            // ADD_Postavchik
            // 
            this.AcceptButton = this.BTN_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_cancel;
            this.ClientSize = new System.Drawing.Size(492, 139);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ADD_Postavchik";
            this.Text = "ADD_Postavchik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADD_Postavchik_FormClosing);
            this.Load += new System.EventHandler(this.ADD_Postavchik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MyDBDataSet myDBDataSet;
        private MyDBDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        public System.Windows.Forms.BindingSource postavchikBindingSource;
    }
}