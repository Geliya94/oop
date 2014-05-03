using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemPharmacy
{
    public partial class Preparat : Form
    {
        public Preparat()
        {
            InitializeComponent();
        }

        private void Preparat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.preparatDGV". При необходимости она может быть перемещена или удалена.
            this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            ADD_Preparat adp = new ADD_Preparat();
            preparatDGVBindingSource.AddNew();
            adp.preparatBindingSource.DataSource = preparatDGVBindingSource;
            adp.preparatBindingSource.Position = preparatDGVBindingSource.Position;
            if (adp.ShowDialog() == DialogResult.OK)
            {
                preparatDGVTableAdapter.Update(myDBDataSet.preparatDGV);
                preparatDGVTableAdapter.Fill(myDBDataSet.preparatDGV);
            }
        }

        private void BTN_UPD_Click(object sender, EventArgs e)
        {
            ADD_Preparat adp = new ADD_Preparat();
            preparatDGVBindingSource.AddNew();
            adp.preparatBindingSource.DataSource = preparatDGVBindingSource;
            adp.preparatBindingSource.Position = preparatDGVBindingSource.Position;
            if (adp.ShowDialog() == DialogResult.OK)
            {
                preparatDGVTableAdapter.Update(myDBDataSet.preparatDGV);
                preparatDGVTableAdapter.Fill(myDBDataSet.preparatDGV);
            }
        }

        private void BTN_DEL_Click(object sender, EventArgs e)
        {
            preparatDGVBindingSource.RemoveCurrent();
            preparatDGVBindingSource.EndEdit();
            this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
        }

        private void Preparat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.nalDGVTableAdapter.Fill(this.myDBDataSet.NalDGV);
        }

        private void Preparat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = new Form1();
            f.nalDGVTableAdapter.Fill(this.myDBDataSet.NalDGV);
            f.nalDGVTableAdapter.Update(this.myDBDataSet.NalDGV);
        }
    }
}
