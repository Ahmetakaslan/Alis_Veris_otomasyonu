using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Cloud.Firestore;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using System.Reflection;
using System.IO;



namespace Otomasyon1
{
    
    public partial class FormÜrünSat : Form
    {
        bool isClick = false;
        FirestoreDb db;
        public string isimUrunSat;
        public FormÜrünSat()
        {
            InitializeComponent();
        }
        ProductDal productdal = new ProductDal();
        public void Dondur()
        {
            dataGridView1.DataSource = productdal.GetAll();
        }
        private void Form1_Load(object sender , EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet3.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.mainDataSet3.Products);
            connectFirebase();
            richTextBox1.Enabled = true;
            Labelİsim.Text = isimUrunSat;
            Dondur();

        }

        private void button1_Click(object sender , EventArgs e)
        {
            productdal.Add(new Products
            {
                Name = tbxÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxfiyat.Text) ,
                StockAmount = Convert.ToInt32(tbxürünadedi.Text) ,
                Explain = richTextBox1.Text.ToString()

            }); ;
            dataGridView1.DataSource = productdal.GetAll();
            MessageBox.Show("Ürününüz eklendi");
        }

        private void btnGüncelle_Click(object sender , EventArgs e)
        {
            productdal.Update(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) ,
                Name = tbxgücelleÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxgücelleÜrünFiyatı.Text) ,
                StockAmount = Convert.ToInt32(tbxgüncelleÜrünAdedi.Text) ,
                Explain = richTextBox1.Text
            });
            Dondur();
            MessageBox.Show("Ürün güncellendi");
        }
        public void Equal()
        {
            tbxgücelleÜrünİsmi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxgücelleÜrünFiyatı.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxgüncelleÜrünAdedi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxUrunTuru.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }



        private void dataGridView1_CellClick(object sender , DataGridViewCellEventArgs e)
        {
            Equal();
        }

        private void btnSil_Click(object sender , EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Silinecek Ürün yok");
            }
            else
            {
                productdal.Delete(new Products
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)

                });
                Dondur();
                MessageBox.Show("Ürün Silindi");
                deleteDocumentOnFireBase(tbxUrunTuru.Text , tbxÜrünİsmi.Text);
              
            }

        }

        private void richTextBox1_TextChanged(object sender , EventArgs e)
        {

        }
        public async void deleteDocumentOnFireBase(string collectionName,string name)
        {
            DocumentReference cityRef = db.Collection("Satıcılar").Document("Akaslan").Collection(collectionName).Document(name);
            await cityRef.DeleteAsync();
        }
        

        
        private void tbxürünadedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void tbxgüncelleÜrünAdedi_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
          )
            {
                e.Handled = true;
            }

        }



        private void tbxgücelleÜrünFiyatı_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void tbxfiyat_KeyPress(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void labelControl1_Click(object sender , EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender , EventArgs e)
        {

        }

        private void tbxürünadedi_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxfiyat_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxgüncelleÜrünAdedi_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxgücelleÜrünFiyatı_KeyPress_1(object sender , KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnEkle_Click(object sender , EventArgs e)
        {
            if (tbxÜrünTürü.Text.Equals("") || tbxÜrünİsmi.Text.Equals("") || tbxürünadedi.Text.Equals(""))
            {
            
                    MessageBox.Show("Lütfen Alanları Doldurunuz");
        
            }
            else
            {
                productdal.Add(new Products
                {
                    Name = tbxÜrünİsmi.Text ,
                    UnitPrice = Convert.ToDecimal(tbxfiyat.Text) ,
                    StockAmount = Convert.ToInt32(tbxürünadedi.Text) ,
                    Explain = richTextBox1.Text.ToString() ,
                    Type = tbxÜrünTürü.Text

                });
                dataGridView1.DataSource = productdal.GetAll();
                MessageBox.Show("Ürününüz eklendi");
            }

        }
        private void btnGüncelle_Click_1(object sender , EventArgs e)
        {
            productdal.Update(new Products
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) ,
                Name = tbxgücelleÜrünİsmi.Text ,
                UnitPrice = Convert.ToDecimal(tbxgücelleÜrünFiyatı.Text) ,
                StockAmount = Convert.ToInt32(tbxgüncelleÜrünAdedi.Text) ,
                Explain = richTextBox1.Text ,
                Type = tbxUrunTuru.Text ,
            });
            Dondur();
            MessageBox.Show("Ürün güncellendi");
        }
        public void addFirebase(String type , String fullName)
        {
            DocumentReference document = db.Collection("Satıcılar").Document("Akaslan").Collection(type).Document(fullName);

            Dictionary<string , object> keyValuePairs = new Dictionary<string , object>();

            DateTime time = DateTime.Now;
            keyValuePairs.Add("isim" , tbxÜrünİsmi.Text);
            keyValuePairs.Add("UrunFiyati" , Convert.ToDouble(tbxfiyat.Text));

            keyValuePairs.Add("UrunAdedi" , tbxürünadedi.Text);
            if (richTextBox1.Text != null)
            {
                keyValuePairs.Add("UrunAciklamasi" , richTextBox1.Text);
            }
            else
            {
                keyValuePairs.Add("UrunAciklamasi" , "");
            }
         

            keyValuePairs.Add("ÜrünEklemeTarihi" , time.ToString());
         
            keyValuePairs.Reverse();
            document.SetAsync(keyValuePairs);
            MessageBox.Show("Başarılı");
        }
        public void connectFirebase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"otomasyon.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS" , path);
            db = FirestoreDb.Create("otomasyon-eb3fe");

        }



        private void dataGridView1_DataError(object sender , DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {

        }
    }
}
