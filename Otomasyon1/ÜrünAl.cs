using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using Google.Cloud.Firestore;


namespace Otomasyon1
{
    public partial class FormÜrünAl : Form
    {
        FirestoreDb db;
        double fiyat;
        public string isimUrunAl;
        public FormÜrünAl()
        {
            InitializeComponent();
        }
        static int number = 0;
        // BURADA ALINAN ÜRÜNLERİ VERİ TABANINA EKLEMEK İÇİN
        // KULLANICININ KİM OLDUĞUNU BULMAK İÇİN KULLANICI ADI VE ŞİFRESİNİ 
        // GİRİŞ SAYFASINDAN DEĞİŞKENE ATTADIM
        string girisKullanıcıAdı = FormGirisYap.tempKullanıcıAdı;
        string girisKullanıcıSifre = FormGirisYap.tempSifre;
        ProductDal productDal = new ProductDal();
        PersonDal person = new PersonDal();
        private void Form2_Load(object sender , EventArgs e)
           
        {
            connectFirebase();
     
            try
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.tcmb.gov.tr/kurlar/today.xml");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                string data = reader.ReadToEnd();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(data);
              //  string tarih = " /Tarih_Date";
             //   XmlNode node0 = xml.SelectSingleNode(tarih);
             //   DateTime dateTime = Convert.ToDateTime(xml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string dolarAlis = "/Tarih_Date/Currency[@Kod='USD']/ForexSelling";
                XmlNode node = xml.SelectSingleNode(dolarAlis);
                string euroAlis = "/Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
                XmlNode node2 = xml.SelectSingleNode(euroAlis);
              //  groupBoxDoviz.Text = dateTime.ToShortDateString();
                labelDolarAlis.Text = " Dolar Alış :" + node.InnerText;
                labelEuroAlis.Text = " Euro Aklış " + node2.InnerText;
            }catch (Exception s)
            {
                labelDolarAlis.Text = "Internetiniz kapalı";
                labelEuroAlis.Text = "Internetiniz kapalı";
            }

            // TODO: This line of code loads data into the 'mainDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mainDataSet1.Products);
            dataGridView2.ReadOnly = true;
            Labelİsim.Text = isimUrunAl;
                dataGridView2.DataSource = productDal.GetAll();
            dataType();
        
        }

        private void textBox1_TextChanged(object sender , EventArgs e)
        {
            dataGridView2.DataSource = productDal.Search(tbxAra.Text);
        }
        public void dataType()
        {
            List<string> a=new List<string>();


            using (ProductContext context = new ProductContext())
            {
                
                a = context.Products.Select(x => x.Type).ToList();
            }
            a.Add("Tüm Ürünler");
            a.Reverse();
            a= a.Distinct().ToList();
       
         foreach(string s in a)
            {
             
                comboBox1.Items.Add(s);
            }
            
         
        }
        private void dataGridView2_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            fiyat = Convert.ToDouble(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            tbxAlÜrünİsmi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            if (dataGridView2.CurrentCell.ColumnIndex == 4) { 
                if( dataGridView2.CurrentCell.Value != null )
                {
                    if (!dataGridView2.CurrentCell.Value.Equals(""))
                    {
                        tbxAçıklama.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    }
                    else
                    {
                        tbxAçıklama.Text = "";
                    }
                }
            } 
        }
        private void tbxAlınacakÜrünAdedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) 
         )
            {
                e.Handled = true;
            }

        }
        String KullanıcıAdı = FormGirisYap.kullaniciAdi;
        public void addProdcutToFirebase(String email,String name)
        {
          
            String açıklama;
            if (dataGridView2.CurrentRow.Cells[4].Value !=null)
            {
                 açıklama = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                 açıklama = "";
            }
            try
            {
                DocumentReference document = db.Collection("Alıcılar").Document(email).Collection(KullanıcıAdı).Document(name);
                Dictionary<string , object> keyValuePairs = new Dictionary<string , object>();
                DateTime time = DateTime.Now;
                keyValuePairs.Add("isim" , name);
                keyValuePairs.Add("UrunFiyati" , fiyat);
                int a = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value);
              
                if (a>=Convert.ToInt32(tbxAlınacakÜrünAdedi.Text))
                {
                    number =number+Convert.ToInt32(tbxAlınacakÜrünAdedi.Text);
                    keyValuePairs.Add("UrunAdedi" ,number);
                }
                keyValuePairs.Add("UrunAciklamasi" ,açıklama);
                keyValuePairs.Add("AlimTarihi" , time.ToString());
                keyValuePairs.Add("UrunTuru" , dataGridView2.CurrentRow.Cells[5].Value.ToString());
                keyValuePairs.Reverse();
                document.SetAsync(keyValuePairs);
                MessageBox.Show("Başarılı");
            }
            catch (Exception a)
            {
                MessageBox.Show("hata");
            }
        }
        public void connectFirebase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"otomasyon.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS" , path);
            db = FirestoreDb.Create("otomasyon-eb3fe");
        }
        private void dataGridView2_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {
             fiyat = Convert.ToDouble(dataGridView2.CurrentRow.Cells[2].Value.ToString());
        }

        async public void FetchPreviousData(String email , String name)
        {
            DocumentReference docRef = db.Collection("Alıcılar").Document(email).Collection(KullanıcıAdı).Document(name);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                AlinanUrunler alinan = snapshot.ConvertTo<AlinanUrunler>();
                number = alinan.UrunAdedi;
            }
            else
            {
                MessageBox.Show("Document {0} does not exist!" , snapshot.Id);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender , EventArgs e)
        {

            if(comboBox1.Text.Equals("Tüm Ürünler"))
            {
                dataGridView2.DataSource = productDal.GetAll();
            }
            else
            {
                using (ProductContext product = new ProductContext())
                {
                    string name = product.Products.FirstOrDefault(p => p.Type.Equals(comboBox1.Text)).Type;
                    dataGridView2.DataSource = productDal.seatchWithType(name);

                }
            }
           
        }

        private void myButton1_Click(object sender , EventArgs e)
        {

            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Alınacak Ürün Yok");
            }
            else
            {
                if (tbxAlÜrünİsmi.Text.Equals("") || tbxAlınacakÜrünAdedi.Text.Equals(""))
                {
                    MessageBox.Show("Alanları Doldurun Lütfen");
                }
                else
                {
                    FetchPreviousData(FormGirisYap.email , tbxAlÜrünİsmi.Text);

                    if (tbxAlınacakÜrünAdedi.Text.Equals("") || tbxAlÜrünİsmi.Text.Equals(""))
                    {
                        MessageBox.Show("Lütfen Alanları Doldurunuz");
                    }
                    else
                    {
                        FormGirisYap giriş = new FormGirisYap();
                        // istrue Aşağıda  kulllanılmak için yazıldı

                        // burada var olan ürün alındığında stok azaltmak için kullanılıyor
                        int currentStockCount = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());

                        int temp2 = Convert.ToInt32(tbxAlınacakÜrünAdedi.Text);
                        if (currentStockCount >= temp2)
                        {
                            ProductContext product = new ProductContext();
                            int id = product.Person.FirstOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Id;
                            // kişinin aldığı ürün sayısını güncelliyoruz
                            int varOlan = product.Person.FirstOrDefault(p => p.Id.Equals(id)).Piece;
                            person.Update(new Person
                            {
                                Id = product.Person.SingleOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Id ,
                                Name = product.Person.SingleOrDefault(p => p.Email.Equals(girisKullanıcıAdı) && p.Password.Equals(girisKullanıcıSifre)).Name ,
                                Email = girisKullanıcıAdı ,
                                Password = girisKullanıcıSifre ,
                                // burada Alinan ürünleri Artırmalyız

                                Piece = Convert.ToInt32(tbxAlınacakÜrünAdedi.Text) + varOlan
                            });
                            currentStockCount = currentStockCount - temp2;
                            productDal.Update(new Products
                            {
                                Id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) ,
                                Name = dataGridView2.CurrentRow.Cells[1].Value.ToString() ,
                                UnitPrice = Convert.ToDecimal(dataGridView2.CurrentRow.Cells[2].Value) ,
                                StockAmount = currentStockCount
                            });
                            dataGridView2.DataSource = productDal.GetAll();

                            MessageBox.Show("Ürünü aldınız");

                            addProdcutToFirebase(FormGirisYap.email , tbxAlÜrünİsmi.Text);
                        }
                        else
                        {// ürünün stokts bulunmaması durumunda

                            MessageBox.Show("Üzgünüz belirtilen miktarda ürünümüz \n bulunmamaktadır");
                        }

                    }
                }
            }

        }
        private void SatinAldiklarim_Click(object sender , EventArgs e)
        {
            SatinAldiklarim satin = new SatinAldiklarim();
            this.Hide();
            satin.ShowDialog();
            this.Show();
        }

        private void btnSatınAl_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSatınAl.PerformClick();
        }

  
    }
}

