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
    public partial class ADD_algoritm : Form
    {
        public ADD_algoritm()
        {
            InitializeComponent();
        }

        private void ADD_algoritm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Algoritm". При необходимости она может быть перемещена или удалена.
            this.algoritmTableAdapter.Fill(this.myDBDataSet.Algoritm);
        }

        private void ADD_algoritm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                algoritmBindingSource.EndEdit();
            else
                algoritmBindingSource.CancelEdit();
        }
    }
}
