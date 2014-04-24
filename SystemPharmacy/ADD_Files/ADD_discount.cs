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
    public partial class ADD_svyaz : Form
    {
        public ADD_svyaz()
        {
            InitializeComponent();
        }

        private void ADD_svyaz_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Algoritm". При необходимости она может быть перемещена или удалена.
            this.algoritmTableAdapter.Fill(this.myDBDataSet.Algoritm);
// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Discount". При необходимости она может быть перемещена или удалена.
            this.discountTableAdapter.Fill(this.myDBDataSet.Discount);

        }

        private void ADD_svyaz_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (DialogResult == DialogResult.OK)
            {
                discountBindingSource.EndEdit();
            }
            else
            {
                discountBindingSource.CancelEdit();
            }    
        }
    }
}
