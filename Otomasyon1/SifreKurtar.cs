using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon1
{
    public partial class SifreKurtar : Form
    {
     public static   string girilenEmail;
        string randomCode;
        static string password;
        public SifreKurtar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender , EventArgs e)
        {
            if (randomCode == tbxEnterCode.Text.ToString())
            {

                this.Hide();
                ŞifreDeğiştir renovation = new ŞifreDeğiştir();
                renovation.ShowDialog();
         
            }
            else
            {
                MessageBox.Show("Kod hatalı");
            }

        }

        private void button2_Click(object sender , EventArgs e)
        {

            try
            {
                string myMail, message;
                Random random = new Random();
                randomCode = (random.Next(999999)).ToString();
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                myMail = "akaslan47yazilim@gmail.com";
                password = "zkygndermjqqghnu";
                message = "****** Code for restart is  \"******" + $"\n{"=" + randomCode}";
                mail.From = new MailAddress(myMail);
                mail.To.Add(tbxSendEmail.Text.ToString());
                mail.Subject = "Restarting  message";
                mail.Body = message;
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(myMail , password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);
                MessageBox.Show("Göderildi");

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                MessageBox.Show("Hatalı bir e mail");
            }






        }

        private void button2_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGönder.PerformClick();
        }

         private void SifreKurtar_Load(object sender , EventArgs e)
        {
        
        }

        private void tbxSendEmail_TextChanged(object sender , EventArgs e)
        {
            girilenEmail = tbxSendEmail.Text;
        }
    }
}
