using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataBase;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;

namespace SystemPharmacy
{
    public partial class Zakaz : Form
    {
        public int id;
        public Zakaz(int _id)
        {
            this.id = _id;
        }
        List<Zakaz> list = new List<Zakaz>();
        public Zakaz()
        {
            InitializeComponent();
        }


        private void BTN_add_Click(object sender, EventArgs e)
        {
            list.Add(new Zakaz(list.Count + 1));
            dataGridView1.Rows.Add();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].id = i + 1;
                dataGridView1[0, dataGridView1.RowCount - 1].Value = list[i].id;
                dataGridView1[1, dataGridView1.RowCount - 1].Value = comboBox1.Text;
                dataGridView1[2, dataGridView1.RowCount - 1].Value = comboBox2.Text;
                dataGridView1[3, dataGridView1.RowCount - 1].Value = textBox1.Text;
                dataGridView1[4, dataGridView1.RowCount - 1].Value = textBox2.Text;
            }
        }

        private void BTN_upd_Click(object sender, EventArgs e)
        {

        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            //if (this.dataGridView1.SelectedRows.Count > 0)
            //{
             //   this.dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
           // }
            
        }

        private void Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Preparat". При необходимости она может быть перемещена или удалена.
            this.preparatTableAdapter.Fill(this.myDBDataSet.Preparat);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string r = "1234567890/., ";
            for (int i = 0; i < r.Length; i++)
            {
                if (e.KeyChar == r[i])
                {
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string r = "1234567890/., ";
            for (int i = 0; i < r.Length; i++)
            {
                if (e.KeyChar == r[i])
                {
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "*.pdf|*.PDF";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var doc = new Document();
                BaseFont baseFont = BaseFont.CreateFont(@"TIMES.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                iTextSharp.text.Font zag = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font curs = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font other_text = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font othtext = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
                PdfWriter.GetInstance(doc, new FileStream(@saveFileDialog1.FileName, FileMode.Create));
                doc.Open();

                Paragraph par = new Paragraph("Акт закупок", zag);
                par.Alignment = Element.ALIGN_CENTER;
                Paragraph variant = new Paragraph("Аптека № 10", curs);
                variant.Alignment = Element.ALIGN_RIGHT;
                Paragraph otstup = new Paragraph("\r\n");
                doc.Add(par);

                doc.Add(otstup);
                PdfPTable table = new PdfPTable(5);

                PdfPCell cell1 = new PdfPCell(new Phrase("№", other_text));
                PdfPCell cell2 = new PdfPCell(new Phrase("Препарат", other_text));
                PdfPCell cell3 = new PdfPCell(new Phrase("Поставщик", other_text));
                PdfPCell cell4 = new PdfPCell(new Phrase("Количество", other_text));
                PdfPCell cell5 = new PdfPCell(new Phrase("Сумма", other_text));
                

                table.AddCell(cell1);
                table.AddCell(cell2);
                table.AddCell(cell3);
                table.AddCell(cell4);
                table.AddCell(cell5);
                

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            string tempS = dataGridView1.Rows[i].Cells[j].Value.ToString();

                            cell1 = new PdfPCell(new Phrase(tempS, othtext));
                            table.AddCell(cell1);
                        }
                    }
                }

                doc.Add(table);
                doc.Add(variant);
                doc.Close();

                MessageBox.Show("ok");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
