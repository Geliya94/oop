using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data;


namespace SystemPharmacy
{
    public class Class_Zakupki_Excel
    {
      public int Zakupki(string pathodb, string pathoffile)
        {
            int resuly = 0;
          /*
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlDataAdapter da = new SqlDataAdapter("Select * from Preparat", s);
          //  MyDBDataSet ds = new MyDBDataSet();
           // da.Fill(ds, "Preparat");

            int resuly = 0;
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook file;
            file = excelapp.Workbooks.Open(pathoffile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel.Sheets sheets = excelapp.Worksheets;
            Excel.Worksheet worksheet;
            worksheet = (Excel.Worksheet)sheets.get_Item(1);
            Excel.Range cell_1 = (Excel.Range)worksheet.Cells[1, 1];
            int i = 1, j = 1;
            string a1 = Convert.ToString(cell_1.Value2);
            a1 = a1.ToLower();
          DataBase bd = new DataBase(pathodb);
            Excel.Range cell_2;
            
                i = 3;
                cell_1 = (Excel.Range)worksheet.Cells[i, 1];
                while (Convert.ToString(cell_1.Value2) != null)
                {
                    i++;
                    cell_1 = (Excel.Range)worksheet.Cells[i, 1];
                }
                int rowend = i-1;
                bool datt = false;
                string date = "";
                while (datt == false)
                {
                    if (Convert.ToString((cell_2 = (Excel.Range)worksheet.Cells[i, 6]).Value2) != null)
                    {
                        datt = true;
                     date = Convert.ToString((cell_2 = (Excel.Range)worksheet.Cells[i, 6]).Value2);
                    }
                    i++;
                }
                for (i = 3; i <= rowend; i++)
                {
                    cell_2 = (Excel.Range)worksheet.Cells[i, 4];
                    string postavchik = Convert.ToString(cell_2.Value2);
                    int Id_postavchik = FindPostav(postavchik);
                    string name = Convert.ToString((cell_2 = (Excel.Range)worksheet.Cells[i,1]).Value2);
                    int kolvo = Convert.ToInt32((cell_2 = (Excel.Range)worksheet.Cells[i, 3]).Value2);
                    float price = Convert.ToDouble((cell_2 = (Excel.Range)worksheet.Cells[i, 2]).Value2);
                    int id_prep = bd.FindIdPrep(Id_postavchik);
                    bd.Update_Preparat(id_prep, Id_postavchik, name, price, kolvo);

                }
            file.Close();
            excelapp.Quit();
            return resuly;*/
            return resuly;
 
        }
        public int FindPostav(string post)
        {
            string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet(); 
            SqlDataAdapter da = new SqlDataAdapter("Select * from Postavchik", s);
            da.Fill(ds,"Postavchik");
            
            DataTable dt = ds.Tables["Postavchik"];
            int id = -1;
            var q = dt.AsEnumerable()
                .Where(t => t.Field<string>("Name") == post)
                .Select(t => t);

            foreach (var i in q)
            { id = Convert.ToInt32(i); }
            return id;
           /* string s = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\MyDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Discount", s);
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Card", s);
           da.Fill(ds, "Discount");
            da1.Fill(ds, "Card");
            DataTable dt = ds.Tables["Discount"];
           DataTable dt1 = ds.Tables["Card"];
              MyDBDataSet.AlgoritmRow index = (MyDBDataSet.AlgoritmRow)((DataRowView)algoritmBindingSource.Current).Row;*/
        }

    }
}
