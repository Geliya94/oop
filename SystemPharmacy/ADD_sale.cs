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
    public partial class ADD_sale : Form
    {
        public ADD_sale()
        {
            InitializeComponent();
        }

        private void ADD_sale_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Sale". При необходимости она может быть перемещена или удалена.
            this.saleTableAdapter.Fill(this.myDBDataSet.Sale);

        }

        private void ADD_sale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                saleBindingSource.EndEdit();
            else
                saleBindingSource.CancelEdit();
        }

    }
}
