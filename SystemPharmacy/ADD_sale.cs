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
           // if (f1 != null)
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            int index = f1.dataGridView1.CurrentCell.RowIndex;
            int kol = Convert.ToInt32(textBox3.Text);
            textBox2.Text = (kol * Convert.ToInt32(textBox2.Text)).ToString();
        }

       
    }
}
