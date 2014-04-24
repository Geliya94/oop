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
    public partial class ADD_group : Form
    {
        public ADD_group()
        {
            InitializeComponent();
        }

        private void ADD_group_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (DialogResult == System.Windows.Forms.DialogResult.OK)
                groupBindingSource.EndEdit();
            else
                groupBindingSource.CancelEdit();
        }

        private void ADD_group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.myDBDataSet.Group);
        }
    }
}
