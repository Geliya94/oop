using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;

namespace SystemPharmacy
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Mail_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Postavchik". При необходимости она может быть перемещена или удалена.
            this.postavchikTableAdapter.Fill(this.myDBDataSet.Postavchik);

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //FileStream f1 = new FileStream(openFileDialog1.FileName, FileMode.Open);
            //using (StreamReader file = new StreamReader(f1))
            //{
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
            SmtpClient client = new SmtpClient(smpt.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(usrname.Text, password.Text);
            client.EnableSsl = true;
            string file = "D:\\5.pdf";

            System.Net.Mail.Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);
            ContentDisposition disposition = attach.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);

            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

            mail.Attachments.Add(attach);



            client.Send(mail);
            MessageBox.Show("Ok");

        }

        

       
    }
}
