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
    public partial class ADD_zakaz : Form
    {
        public ADD_zakaz()
        {
            InitializeComponent();
        }

        private void ADD_zakaz_Load(object sender, EventArgs e)
        {/*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.preparatDGV". При необходимости она может быть перемещена или удалена.
            this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.preparatDGV". При необходимости она может быть перемещена или удалена.
            this.preparatDGVTableAdapter.Fill(this.myDBDataSet.preparatDGV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.myDBDataSet.Zakaz);*/

        }

        private void ADD_zakaz_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            if (DialogResult == DialogResult.OK)
            {
                zakazBindingSource.EndEdit();
            }
            else
            {
                zakazBindingSource.CancelEdit();
            }*/
        }
    }
}
