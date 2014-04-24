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
    public partial class ADD_card : Form
    {
        public ADD_card()
        {
            InitializeComponent();
        }

        private void ADD_card_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Algoritm". При необходимости она может быть перемещена или удалена.
            this.algoritmTableAdapter.Fill(this.myDBDataSet.Algoritm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Card". При необходимости она может быть перемещена или удалена.
            this.cardTableAdapter.Fill(this.myDBDataSet.Card);
        }

        private void ADD_card_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                cardBindingSource.EndEdit();
            else
                cardBindingSource.CancelEdit();
        }
    }
}
