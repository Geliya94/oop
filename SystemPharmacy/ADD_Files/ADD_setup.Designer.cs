namespace SystemPharmacy
{
    partial class ADD_setup
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
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ok = new System.Windows.Forms.Button();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.SetupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tB1
            // 
            this.tB1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "Name", true));
            this.tB1.Location = new System.Drawing.Point(226, 12);
            this.tB1.Multiline = true;
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(164, 21);
            this.tB1.TabIndex = 0;
            // 
            // tB3
            // 
            this.tB3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setupBindingSource, "Porog", true));
            this.tB3.Location = new System.Drawing.Point(226, 48);
            this.tB3.Multiline = true;
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(164, 20);
            this.tB3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование настройки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пороговое значение";
            // 
            // BTN_ok
            // 
            this.BTN_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_ok.Location = new System.Drawing.Point(244, 91);
            this.BTN_ok.Name = "BTN_ok";
            this.BTN_ok.Size = new System.Drawing.Size(70, 20);
            this.BTN_ok.TabIndex = 6;
            this.BTN_ok.Text = "OK";
            this.BTN_ok.UseVisualStyleBackColor = true;
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_cancel.Location = new System.Drawing.Point(320, 91);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(70, 20);
            this.BTN_cancel.TabIndex = 7;
            this.BTN_cancel.Text = "CANCEL";
            this.BTN_cancel.UseVisualStyleBackColor = true;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ADD_setup
            // 
            this.AcceptButton = this.BTN_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_cancel;
            this.ClientSize = new System.Drawing.Size(409, 134);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_cancel);
            this.Controls.Add(this.BTN_ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ADD_setup";
            this.Text = "ADD_setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADD_setup_FormClosing);
            this.Load += new System.EventHandler(this.ADD_setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ok;
        private System.Windows.Forms.Button BTN_cancel;
        private MyDBDataSet myDBDataSet;
        private MyDBDataSetTableAdapters.SetupTableAdapter setupTableAdapter;
        public System.Windows.Forms.BindingSource setupBindingSource;
    }
}