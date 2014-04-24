using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace SystemPharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
            this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
          //  this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);
          //  Class_Zakupki_Excel cl = new Class_Zakupki_Excel();
           // int count=0;
           // this.Text = "System_of_Pharmacy";
           // string str= @"D:\Zakupki";
          //  DirectoryInfo docs = new DirectoryInfo(str);
          //  FileInfo[] files = docs.GetFiles();
           // foreach (FileInfo f in files)
           // { count++;
           // int result = cl.Zakupki(@"D:\MyDB.mdf", f.FullName);
          //  f.Delete();
          //  }
          //  MessageBox.Show(count.ToString());

        }
        
        private void BTN_zakaz_Click(object sender, EventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
        }

        private void algoritm_menu_Click_1(object sender, EventArgs e)
        {

            Algoritm alg = new Algoritm();
            alg.Show();
        }

        private void card_menu_Click_1(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Show();
        }

        private void setup_menu_Click(object sender, EventArgs e)
        {
            Setup set = new Setup();
            set.Show();
        }

        private void postavchik_menu_Click(object sender, EventArgs e)
        {
            Postavchik post = new Postavchik();
            post.Show();
        }

        private void group_menu_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ADD_Preparat ads = new ADD_Preparat();
            preparatBindingSource.AddNew();
            ads.preparatBindingSource.DataSource = preparatBindingSource;
            ads.preparatBindingSource.Position = preparatBindingSource.Position;
            if (ads.ShowDialog() == DialogResult.OK)
            {
                preparatTableAdapter.Update(myDBDataSet.Preparat);
                this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);

            }
        }
    }
}
