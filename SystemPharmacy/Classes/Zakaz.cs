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
    public partial class Zakaz : Form
    {
        public Zakaz()
        {
            InitializeComponent();
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.zakazDGV". При необходимости она может быть перемещена или удалена.
          //  this.zakazDGVTableAdapter.Fill(this.myDBDataSet.zakazDGV);

        }

        private void BTN_add_Click(object sender, EventArgs e)
        {/*
            ADD_zakaz sv = new ADD_zakaz();
            zakazDGVBindingSource.AddNew();
            sv.zakazBindingSource.DataSource = zakazDGVBindingSource;
            sv.zakazBindingSource.Position = zakazDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                zakazDGVTableAdapter.Update(myDBDataSet.zakazDGV);
                this.zakazDGVTableAdapter.Fill(this.myDBDataSet.zakazDGV);
                // dataGridView1.CurrentCell = dataGridView1.Rows[managerDGVBindingSource.Count - 1].Cells[2];
            }*/

        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
           /* ADD_zakaz sv = new ADD_zakaz();
            sv.zakazBindingSource.DataSource = zakazDGVBindingSource;
            sv.zakazBindingSource.Position = zakazDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                zakazDGVTableAdapter.Update(myDBDataSet.zakazDGV);
                this.zakazDGVTableAdapter.Fill(this.myDBDataSet.zakazDGV);
                // dataGridView1.CurrentCell = dataGridView1.Rows[managerDGVBindingSource.Count - 1].Cells[2];
            }*/
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {/*
            zakazDGVBindingSource.RemoveCurrent();
            zakazDGVBindingSource.EndEdit();
            this.zakazDGVTableAdapter.Fill(this.myDBDataSet.zakazDGV);*/
        }
    }
}
