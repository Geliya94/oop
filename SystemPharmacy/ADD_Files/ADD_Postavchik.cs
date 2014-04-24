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
    public partial class ADD_Postavchik : Form
    {
        public ADD_Postavchik()
        {
            InitializeComponent();
        }

        private void ADD_Postavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);
        }

        private void ADD_Postavchik_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                postavchikBindingSource.EndEdit();
            else
                postavchikBindingSource.CancelEdit();
        }
    }
}
