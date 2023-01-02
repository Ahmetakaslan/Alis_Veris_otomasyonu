using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Reflection.Emit;

namespace Otomasyon1
{

    public partial class FormAnaSayfa : Form
    {

        public FormAnaSayfa()
        {
             InitializeComponent();
            BorderStyle borderStyle = BorderStyle.FixedSingle;

        }
        public static bool Tıklandı = false;

        private void FormAnaSayfa_Load(object sender , EventArgs e)
        {
            DovizKuru();
           
          
        }

        private void Al_Click(object sender , EventArgs e)
        {
            Tıklandı = true;
            FormGirisYap form = new FormGirisYap();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Sat_Click(object sender , EventArgs e)
        {
            Tıklandı = false;
            FormGirisYap form = new FormGirisYap();
            this.Hide();
            form.ShowDialog();
            this.Show();

        }

        private void labelDolarAlis_Click(object sender , EventArgs e)
        {

        }
        public  void DovizKuru()
        {
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.tcmb.gov.tr/kurlar/today.xml");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string data = reader.ReadToEnd();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(data);
               //   string tarih = "/Tarih_Date";
              //  XmlNode node0 = xml.SelectSingleNode(tarih);
             //   DateTime dateTime = DateTime.Parse(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string dolarAlis = "/Tarih_Date/Currency[@Kod='USD']/ForexSelling";
                XmlNode node = xml.SelectSingleNode(dolarAlis);
                string euroAlis = "/Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
                XmlNode node2 = xml.SelectSingleNode(euroAlis);
                labelDolarAlis.Text =  " Dolar Alış :" + node.InnerText;
                labelEuroAlis.Text = " Euro Alış " + node2.InnerText;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                labelDolarAlis.Text = "Internetiniz açık değil";
                labelEuroAlis.Text = "Internetiniz açık değil";
                   
            }
        }

        private void Al_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Al.PerformClick();
        }

        private void Sat_Click_1(object sender , EventArgs e)
        {
            Tıklandı = false;
            FormGirisYap form = new FormGirisYap();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Al_Click_1(object sender , EventArgs e)
        {
            Tıklandı = true;
            FormGirisYap form = new FormGirisYap();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
