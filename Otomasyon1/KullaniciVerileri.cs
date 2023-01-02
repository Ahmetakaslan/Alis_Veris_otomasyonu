using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon1
{
    public partial class KullaniciVerileri : Form
    {
        public KullaniciVerileri()
        {
            InitializeComponent();
        }
        PersonDal person = new PersonDal();
        private void KullaniciVerileri_Load(object sender , EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet2.People' table. You can move, or remove it, as needed.

            MusteriAlımGrafikleri();
            Yenile();

        }
        public void Yenile()
        {
            dataGridViewKulanıcıVerileri.DataSource = person.GetAll();
        }
        private void BtnSil_Click(object sender , EventArgs e)
        {

            person.Delete(new Person
            {
                Id = Convert.ToInt32(dataGridViewKulanıcıVerileri.CurrentRow.Cells[0].Value)
            });
            Yenile();
            MessageBox.Show("kullanıcı silindi");

        }

       
        private void comboBox1_SelectedIndexChanged(object sender , EventArgs e)
        {
            using (ProductContext product = new ProductContext())
            {
                int a = product.Person.SingleOrDefault(p => p.Email.Equals(comboBox1.Text)).Piece;
                progressBar1.Value = a;
                labelAlım.Text = a.ToString();
            }
        }
        public void MusteriAlımGrafikleri()
        {
            List<Person> a;
          
            using (ProductContext context = new ProductContext())
            {
                a = context.Person.ToList();
            }
            // Kullanıc adıda id gibi benzersiz olmalı
            // En çok ürün alan 10 kişiyi Burada ComboBox a gönderiliyor;
         
          // burada sıralama şekli
            List<Person> myLİst= a.OrderBy(o => o.Piece).ToList();
          // küçükten büyüğe sıralıyor Reverse yaparak büyükten küçüğe sıralyınız
            myLİst.Reverse();
            //ayrı yetten bir ek
            //a.Sort((x , y) => x.AlinanÜrünSayısı.CompareTo(y.AlinanÜrünSayısı));

            if (myLİst.Count >= 10)
            {
                for (int i = 0; i<10; i++)
                {
                    comboBox1.Items.Add(myLİst[i].Email);

                }
            }

            else
            {
                for (int i = 0; i < myLİst.Count; i++)
                {
                    comboBox1.Items.Add(myLİst[i].Email);

                }
            }


        }
   

        private void textBox1_TextChanged(object sender , EventArgs e)
        {
            using(ProductContext product=new ProductContext())
            {
                dataGridViewKulanıcıVerileri.DataSource = person.searchName(tbxAraKullanıcıVerileri.Text);

            }
        }

        private void dataGridViewKulanıcıVerileri_CellContentClick(object sender , DataGridViewCellEventArgs e)
        {

        }

        private void Sat_Click(object sender , EventArgs e)
        {
            FormÜrünSat formÜrünSat=new FormÜrünSat();
            this.Hide();
            formÜrünSat.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender , EventArgs e)
        {
        
        }
    }
}
