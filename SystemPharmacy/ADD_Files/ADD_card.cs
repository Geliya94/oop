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
                Card ca = this.Owner as Card;
                int index = ca.dataGridView1.CurrentCell.RowIndex;
                DataBase db = new DataBase(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\user\Documents\GitHub\oop\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                var q = from k in db.Card select k;
                var c = from i in db.Discount select i;
               // var w = from g in db.Discount select g.summa;
                List<string> qwe = new List<string>();
                foreach (var k in q)
                {
                    foreach (var i in c)
                        if (k.id_algoritm == i.id_algoritm)
                        {
                            { qwe.Add(i.summa.ToString()); }
                        }
                }
              //  foreach (var i in qwe)
              //  { MessageBox.Show(i.ToString()); }
                foreach (var k in q)
                {//скидки
                    foreach (var i in c)
                    {
                        if (k.id_algoritm == i.id_algoritm)
                        {
                            for (int j = 0; j < qwe.Count;j++ )
                            {
                                if ((k.summa_nakopl > Convert.ToInt32(qwe[j])) && (k.summa_nakopl < Convert.ToInt32(qwe[j+1])))
                                {
                                    if(i.summa== Convert.ToInt32(qwe[j]))
                                    {
                                      //  MessageBox.Show(i.procent.ToString());
                                        ca.dataGridView1[3, index].Value = i.procent.ToString();
                                }
                                }
                            }
                            
                        }
                    }
                }
                cardBindingSource.EndEdit();
            }
            else
                cardBindingSource.CancelEdit();
        }

        
    }
}
