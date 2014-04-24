namespace SystemPharmacy
{
    partial class Zakaz
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_upd = new System.Windows.Forms.Button();
            this.BTN_del = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(730, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTN_upd
            // 
            this.BTN_upd.Location = new System.Drawing.Point(514, 260);
            this.BTN_upd.Name = "BTN_upd";
            this.BTN_upd.Size = new System.Drawing.Size(74, 23);
            this.BTN_upd.TabIndex = 10;
            this.BTN_upd.Text = "Изменить";
            this.BTN_upd.UseVisualStyleBackColor = true;
            this.BTN_upd.Click += new System.EventHandler(this.BTN_upd_Click);
            // 
            // BTN_del
            // 
            this.BTN_del.Location = new System.Drawing.Point(608, 260);
            this.BTN_del.Name = "BTN_del";
            this.BTN_del.Size = new System.Drawing.Size(74, 23);
            this.BTN_del.TabIndex = 9;
            this.BTN_del.Text = "Удалить";
            this.BTN_del.UseVisualStyleBackColor = true;
            this.BTN_del.Click += new System.EventHandler(this.BTN_del_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(422, 260);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(74, 23);
            this.BTN_add.TabIndex = 8;
            this.BTN_add.Text = "Добавить";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(754, 299);
            this.Controls.Add(this.BTN_upd);
            this.Controls.Add(this.BTN_del);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zakaz";
            this.Text = "Zakaz";
            this.Load += new System.EventHandler(this.Zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_upd;
        private System.Windows.Forms.Button BTN_del;
        private System.Windows.Forms.Button BTN_add;
    }
}