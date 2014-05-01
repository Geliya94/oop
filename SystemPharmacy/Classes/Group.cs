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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.myDBDataSet.Group);
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Preparat", s);
            da.Fill(ds, "Preparat");
            DataTable dt = ds.Tables["Preparat"];
            MyDBDataSet.GroupRow index = (MyDBDataSet.GroupRow)((DataRowView)groupBindingSource.Current).Row;

            var q = dt.AsEnumerable()
                .Where(t => t.Field<int>("Id_group") == index.Id_group)
                .Select(t => t);

            if (q.Count() == 0)
            {
                groupBindingSource.RemoveCurrent();
                groupBindingSource.EndEdit();
                groupTableAdapter.Update(this.myDBDataSet.Group);
            }
            else { MessageBox.Show("Impossible"); }

        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            ADD_group group = new ADD_group();
            groupBindingSource.AddNew();
            group.groupBindingSource.DataSource = groupBindingSource;
            group.groupBindingSource.Position = groupBindingSource.Position;
            if (group.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                groupTableAdapter.Update(this.myDBDataSet.Group);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_group group = new ADD_group();
            group.groupBindingSource.DataSource = groupBindingSource;
            group.groupBindingSource.Position = groupBindingSource.Position;
            if (group.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                groupTableAdapter.Update(this.myDBDataSet.Group);
        }
    }
}
