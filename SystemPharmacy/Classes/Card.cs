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
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void Card_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.cardDGV". При необходимости она может быть перемещена или удалена.
            this.cardDGVTableAdapter.Fill(this.myDBDataSet.cardDGV);
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            ADD_card sv = new ADD_card();
            sv.Owner = this;
            cardDGVBindingSource.AddNew();
            sv.cardBindingSource.DataSource = cardDGVBindingSource;
            sv.cardBindingSource.Position = cardDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                cardDGVTableAdapter.Update(myDBDataSet.cardDGV);
                this.cardDGVTableAdapter.Fill(this.myDBDataSet.cardDGV);
                // dataGridView1.CurrentCell = dataGridView1.Rows[managerDGVBindingSource.Count - 1].Cells[2];
            }
           
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            cardDGVBindingSource.RemoveCurrent();
            cardDGVBindingSource.EndEdit();
            this.cardDGVTableAdapter.Fill(this.myDBDataSet.cardDGV);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_card sv = new ADD_card();
            sv.cardBindingSource.DataSource = cardDGVBindingSource;
            sv.cardBindingSource.Position = cardDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                cardDGVTableAdapter.Update(myDBDataSet.cardDGV);
                this.cardDGVTableAdapter.Fill(this.myDBDataSet.cardDGV);
                // dataGridView1.CurrentCell = dataGridView1.Rows[managerDGVBindingSource.Count - 1].Cells[2];
            }
        }
    }
}
