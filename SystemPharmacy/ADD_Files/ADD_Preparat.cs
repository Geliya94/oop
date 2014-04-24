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
    public partial class ADD_Preparat : Form
    {
        public ADD_Preparat()
        {
            InitializeComponent();
        }

        private void ADD_Preparat_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);
// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
            this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);
}

        private void ADD_Preparat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                preparatBindingSource.EndEdit();
            }
            else
            {
                preparatBindingSource.CancelEdit();
            }
        }
    }
}
