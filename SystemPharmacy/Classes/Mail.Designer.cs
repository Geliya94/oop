namespace SystemPharmacy
{
    partial class Mail
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
            this.f = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.from = new System.Windows.Forms.TextBox();
            this.usrname = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.ComboBox();
            this.smpt = new System.Windows.Forms.ComboBox();
            this.myDBDataSet = new SystemPharmacy.MyDBDataSet();
            this.postavchikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavchikTableAdapter = new SystemPharmacy.MyDBDataSetTableAdapters.PostavchikTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(46, 30);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(20, 13);
            this.f.TabIndex = 0;
            this.f.Text = "От";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(46, 66);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(32, 13);
            this.t.TabIndex = 1;
            this.t.Text = "кому";
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(46, 97);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(63, 13);
            this.sm.TabIndex = 2;
            this.sm.Text = "Smpt.server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пользователь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тема";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Сообщение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Прикрепить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(144, 30);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(138, 20);
            this.from.TabIndex = 9;
            // 
            // usrname
            // 
            this.usrname.Location = new System.Drawing.Point(144, 122);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(138, 20);
            this.usrname.TabIndex = 10;
            this.usrname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(144, 177);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(138, 20);
            this.subject.TabIndex = 11;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(144, 215);
            this.body.Multiline = true;
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(256, 213);
            this.body.TabIndex = 12;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(144, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(138, 20);
            this.password.TabIndex = 13;
            this.password.UseSystemPasswordChar = true;
            // 
            // to
            // 
            this.to.DataSource = this.postavchikBindingSource;
            this.to.DisplayMember = "Email";
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(144, 57);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(138, 21);
            this.to.TabIndex = 14;
            // 
            // smpt
            // 
            this.smpt.FormattingEnabled = true;
            this.smpt.Items.AddRange(new object[] {
            "smpt.mail.ru",
            "smpt.yandex.ru",
            "smpt.gmail.com"});
            this.smpt.Location = new System.Drawing.Point(144, 88);
            this.smpt.Name = "smpt";
            this.smpt.Size = new System.Drawing.Size(138, 21);
            this.smpt.TabIndex = 15;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 503);
            this.Controls.Add(this.smpt);
            this.Controls.Add(this.to);
            this.Controls.Add(this.password);
            this.Controls.Add(this.body);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.from);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.t);
            this.Controls.Add(this.f);
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavchikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label sm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox usrname;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox body;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox smpt;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource postavchikBindingSource;
        private MyDBDataSetTableAdapters.PostavchikTableAdapter postavchikTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}