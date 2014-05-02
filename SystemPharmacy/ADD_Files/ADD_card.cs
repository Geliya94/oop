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
            {
                DataBase db = new DataBase(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                int s = -1;
                var q = from k in db.Card select k;
                var c = from i in db.Discount select i;
                foreach (var k in q)
                {
                    foreach (var i in c)
                    {
                        if (k.id_algoritm == i.id_algoritm)
                        {
                            if (k.summa_nakopl > i.summa)
                            {
                                MessageBox.Show(i.procent.ToString());
                            }
                        }
                    }
                }

                cardBindingSource.EndEdit();
            }
            else
                cardBindingSource.CancelEdit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           DataBase db = new DataBase(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
          //  Card ca = this.Owner as Card;
           // float sum = float.Parse(textBox1.Text);
             // int index = ca.dataGridView1.CurrentCell.RowIndex;
            //  int sum = 9;
            //  ca.dataGridView1[3, index].Value = sum.ToString();
             /* string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
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

              var c = from i in db.Card select i ;
              foreach (var i in c)
              {
                  var l = from k in db.Discount where k.id_algoritm == i.id_algoritm select k;
              }
            */
       
            
        }
    }
}
