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
    public partial class ADD_preparat_setup : Form
    {
        public ADD_preparat_setup()
        {
            InitializeComponent();
        }

        private void ADD_preparat_setup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Setup". При необходимости она может быть перемещена или удалена.
            this.setupTableAdapter.Fill(this.myDBDataSet.Setup);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
            this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);
           // this.setupTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);

        }


        private void ADD_preparat_setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                preparatBindingSource.EndEdit();
              //  setupBindingSource.EndEdit();
              //  preparSetDGVBindingSource.EndEdit();
            }
            else
            {
                preparatBindingSource.CancelEdit();
              //  setupBindingSource.CancelEdit();
               // preparSetDGVBindingSource.CancelEdit();
            } 
        }
    }
}
