using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace SystemPharmacy
{
    public partial class ADD_sale : Form
    {
        public ADD_sale()
        {
            InitializeComponent();
        }
        private void ADD_sale_Load(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            f1.dataGridView2.Rows.Add(1);
            {
                int index = f1.dataGridView1.CurrentCell.RowIndex;
                textBox1.Text = f1.dataGridView1[2, index].Value.ToString();
                textBox2.Text = f1.dataGridView1[4, index].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            int a = f1.dataGridView2.RowCount;
            int summa=0;
            if (f1.dataGridView2[0, 0].Value == null)
            {
                f1.dataGridView2[0, 0].Value = textBox1.Text;
                f1.dataGridView2[1, 0].Value = textBox3.Text;
                f1.dataGridView2[2, 0].Value = textBox2.Text;
                this.Close();
            }
            else
            {
                f1.dataGridView2[0, a-1].Value = textBox1.Text;
                f1.dataGridView2[1, a-1].Value = textBox3.Text;
                f1.dataGridView2[2, a-1].Value = textBox2.Text;
                this.Close();
            }
            for (int i = 0; i < a; i++)
            { summa += Convert.ToInt32(f1.dataGridView2[2, i].Value); }
            f1.textBox2.Text = summa.ToString();
        }
        public int k = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            int index = f1.dataGridView1.CurrentCell.RowIndex;
            int est = Convert.ToInt32(f1.dataGridView1[5, index].Value);
            int kol = Convert.ToInt32(textBox3.Text);
            if (est < kol) 
            { MessageBox.Show("Указанного количества нет в наличии"); }
            else
            {
                k++;
                textBox2.Text = (kol * Convert.ToInt32(textBox2.Text)).ToString();
               f1.dataGridView1[5, index].Value = (Convert.ToInt32(f1.dataGridView1[5, index].Value) - kol).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
