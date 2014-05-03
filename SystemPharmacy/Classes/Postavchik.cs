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
    public partial class Postavchik : Form
    {
        public Postavchik()
        {
            InitializeComponent();
        }

        private void Postavchik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\эльвира\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Preparat", s);
            da.Fill(ds, "Preparat");
            DataTable dt = ds.Tables["Preparat"];
            MyDBDataSet.PostavchikRow index = (MyDBDataSet.PostavchikRow)((DataRowView)postavchikBindingSource.Current).Row;

            var q = dt.AsEnumerable()
                .Where(t => t.Field<int>("Id_postavchik") == index.Id_postavchik)
                .Select(t => t);

            if (q.Count() == 0)
            {
                postavchikBindingSource.RemoveCurrent();
                postavchikBindingSource.EndEdit();
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
            }
            else { MessageBox.Show("Impossible"); }
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
           ADD_Postavchik add_post = new ADD_Postavchik();
            postavchikBindingSource.AddNew();
            add_post.postavchikBindingSource.DataSource = postavchikBindingSource;
            add_post.postavchikBindingSource.Position = postavchikBindingSource.Position;
            if (add_post.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_Postavchik add_post = new ADD_Postavchik();
            add_post.postavchikBindingSource.DataSource = postavchikBindingSource;
            add_post.postavchikBindingSource.Position = postavchikBindingSource.Position;
            if (add_post.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                postavchikTableAdapter.Update(this.myDBDataSet.Postavchik);
        }
    }
}
