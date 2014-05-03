using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace SystemPharmacy
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.PreparSetDGV". При необходимости она может быть перемещена или удалена.
            this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.PreparSetDGV". При необходимости она может быть перемещена или удалена.
            this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Setup". При необходимости она может быть перемещена или удалена.
            this.setupTableAdapter.Fill(this.myDBDataSet.Setup);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\эльвира\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Preparat", s);
            da.Fill(ds, "Preparat");
            DataTable dt = ds.Tables["Preparat"];
            MyDBDataSet.SetupRow index = (MyDBDataSet.SetupRow)((DataRowView)setupBindingSource.Current).Row;

            var q = dt.AsEnumerable()
                .Where(t => t.Field<int>("Id_setup") == index.Id_setup)
                .Select(t => t);

            if (q.Count() == 0)
            {
                setupBindingSource.RemoveCurrent();
                setupBindingSource.EndEdit();
                setupTableAdapter.Update(this.myDBDataSet.Setup);
            }
            else { MessageBox.Show("Impossible"); }
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
           ADD_setup add_set = new ADD_setup();
            setupBindingSource.AddNew();
            add_set.setupBindingSource.DataSource = setupBindingSource;
            add_set.setupBindingSource.Position = setupBindingSource.Position;
            if (add_set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                setupTableAdapter.Update(this.myDBDataSet.Setup);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_setup add_set = new ADD_setup();
            add_set.setupBindingSource.DataSource = setupBindingSource;
            add_set.setupBindingSource.Position = setupBindingSource.Position;
            if (add_set.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                setupTableAdapter.Update(this.myDBDataSet.Setup);
        }

        private void BTN_add1_Click(object sender, EventArgs e)
        {
            ADD_preparat_setup pr = new ADD_preparat_setup();
           // preparSetDGVBindingSource.AddNew();
           pr.preparatBindingSource.DataSource = preparSetDGVBindingSource;
            pr.preparatBindingSource.Position = preparSetDGVBindingSource.Position;
            if (pr.ShowDialog() == DialogResult.OK)
            {
               preparSetDGVTableAdapter.Update(myDBDataSet.PreparSetDGV);
                this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);
            }
            //preparSetDGVBindingSource.AddNew();
          /*  pr.preparatBindingSource.DataSource = pr.preparatBindingSource1;
            pr.preparatBindingSource.Position = pr.preparatBindingSource1.Position;
            if (pr.ShowDialog() == DialogResult.OK)
            {
                pr.preparatTableAdapter.Update(this.myDBDataSet.Preparat);
                pr.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);
              //  preparSetDGVTableAdapter.Update(myDBDataSet.PreparSetDGV);
              //  this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);
            }*/
        }

        private void DTN_upd1_Click(object sender, EventArgs e)
        {
            ADD_preparat_setup pr = new ADD_preparat_setup();
            pr.preparatBindingSource.DataSource = preparSetDGVBindingSource;
            pr.preparatBindingSource.Position = preparSetDGVBindingSource.Position;
            if (pr.ShowDialog() == DialogResult.OK)
            {
                preparSetDGVTableAdapter.Update(myDBDataSet.PreparSetDGV);
                this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);

            }
        }

        private void BTN_del1_Click(object sender, EventArgs e)
        {
            preparSetDGVBindingSource.RemoveCurrent();
            preparSetDGVBindingSource.EndEdit();
            this.preparSetDGVTableAdapter.Fill(this.myDBDataSet.PreparSetDGV);
        }
    }
}
