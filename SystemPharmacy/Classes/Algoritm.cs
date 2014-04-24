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
    public partial class Algoritm : Form
    {
        public Algoritm()
        {
            InitializeComponent();
        }

        private void Algoritm_Load(object sender, EventArgs e)
        {// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.DiscountDGV". При необходимости она может быть перемещена или удалена.
            this.discountDGVTableAdapter.Fill(this.myDBDataSet.DiscountDGV);
// TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Algoritm". При необходимости она может быть перемещена или удалена.
            this.algoritmTableAdapter.Fill(this.myDBDataSet.Algoritm);
        }
        
        private void BTN_del_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
          
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Discount", s);
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Card", s);
            da.Fill(ds, "Discount");
            da1.Fill(ds, "Card");
            DataTable dt = ds.Tables["Discount"];
            DataTable dt1 = ds.Tables["Card"];

            MyDBDataSet.AlgoritmRow index = (MyDBDataSet.AlgoritmRow)((DataRowView)algoritmBindingSource.Current).Row;

            var q = dt.AsEnumerable()
                .Where(t => t.Field<int>("Id_algoritm") == index.Id_algoritm)
                .Select(t => t); 
           var w = dt1.AsEnumerable()
               .Where(p => p.Field<int>("Id_algoritm") == index.Id_algoritm)
               .Select(p => p);

                if ((q.Count() == 0)&&(w.Count() ==0))
                {
                    algoritmBindingSource.RemoveCurrent();
                    algoritmBindingSource.EndEdit();
                    algoritmTableAdapter.Update(this.myDBDataSet.Algoritm);
                }
                else { MessageBox.Show("Impossible"); }
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            ADD_algoritm add_alg = new ADD_algoritm();
            algoritmBindingSource.AddNew();
            add_alg.algoritmBindingSource.DataSource = algoritmBindingSource;
            add_alg.algoritmBindingSource.Position = algoritmBindingSource.Position;
            if (add_alg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                algoritmTableAdapter.Update(this.myDBDataSet.Algoritm);
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {
            ADD_algoritm add_alg = new ADD_algoritm();
            add_alg.algoritmBindingSource.DataSource = algoritmBindingSource;
            add_alg.algoritmBindingSource.Position = algoritmBindingSource.Position;
            if (add_alg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                algoritmTableAdapter.Update(this.myDBDataSet.Algoritm);
       }

        private void BTN_del1_Click(object sender, EventArgs e)
        {
            discountDGVBindingSource.RemoveCurrent();
            discountDGVBindingSource.EndEdit();
           this.discountDGVTableAdapter.Fill(this.myDBDataSet.DiscountDGV);
        }

        private void BTN_add1_Click(object sender, EventArgs e)
        {
            ADD_svyaz sv = new ADD_svyaz();
            discountDGVBindingSource.AddNew();
            sv.discountBindingSource.DataSource = discountDGVBindingSource;
            sv.discountBindingSource.Position = discountDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK){
                discountDGVTableAdapter.Update(myDBDataSet.DiscountDGV);
                this.discountDGVTableAdapter.Fill(this.myDBDataSet.DiscountDGV);}
        }

        private void BTN_upd1_Click(object sender, EventArgs e)
        {
            ADD_svyaz sv = new ADD_svyaz();
            sv.discountBindingSource.DataSource = discountDGVBindingSource;
            sv.discountBindingSource.Position = discountDGVBindingSource.Position;
            if (sv.ShowDialog() == DialogResult.OK)
            {
                discountDGVTableAdapter.Update(myDBDataSet.DiscountDGV);
                this.discountDGVTableAdapter.Fill(this.myDBDataSet.DiscountDGV);
              
            }
          
        }

   
    }
}
