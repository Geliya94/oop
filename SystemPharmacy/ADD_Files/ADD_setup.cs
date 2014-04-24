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
    public partial class ADD_setup : Form
    {
        public ADD_setup()
        {
            InitializeComponent();
        }

        private void ADD_setup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Setup". При необходимости она может быть перемещена или удалена.
            this.setupTableAdapter.Fill(this.myDBDataSet.Setup);
        }

        private void ADD_setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                setupBindingSource.EndEdit();
            else
                setupBindingSource.CancelEdit();
        }
    }
}
