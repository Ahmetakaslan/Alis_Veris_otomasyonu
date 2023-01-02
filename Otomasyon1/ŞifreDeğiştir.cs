using Otomasyon1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon1
{
    public partial class ŞifreDeğiştir : Form
    {
        // burada picture boxın resim değiştimesini sağliayacaz

        public ŞifreDeğiştir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender , EventArgs e)
        {

        }

        private void button1_Click(object sender , EventArgs e)
        {
         
            using (ProductContext context = new ProductContext())
            {
                SifreKurtar sifre = new SifreKurtar();
             // Sorgu yöntemi 1 ;
                Person b = context.Person
                      .Where(s => s.Email.Equals(SifreKurtar.girilenEmail)).FirstOrDefault<Person>();

              //  *****2. bir sorgulama şekli
                var query = from st in context.Person
                            where st.Email == SifreKurtar.girilenEmail
                            select st;

                var a = query.FirstOrDefault<Person>();
                if (tbxYeniSifre.Text.Equals("") || tbxYEniSifreTekrar.Text.Equals("" ))
                {
                    MessageBox.Show("Alanları doldurunuz");
                }
                
                else if (tbxYeniSifre.Text.Equals(tbxYEniSifreTekrar.Text))
                {
                    if(context.Person.Where(s => s.Email.Equals(SifreKurtar.girilenEmail)).FirstOrDefault<Person>() != null)
                    {
                        PersonDal person = new PersonDal();
                        person.Update(new Person()
                        {
                           

                            Id = b.Id ,
                            Email = b.Email ,
                            Name = b.Name ,
                            Piece = b.Piece ,
                            Password = tbxYeniSifre.Text


                        });
                   
                        pictureBoxTamam.Visible = true;
                        pictureBoxBekle.Visible = false;

                        MessageBox.Show("Şifreniz Güncellendi ");
                        FormGirisYap girisYap = new FormGirisYap();
                        this.Hide();
                        this.Close();
                        girisYap.ShowDialog();
                    }
                    else
                    {
                        pictureBoxTamam.Visible = false;
                        pictureBoxBekle.Visible = true;
             
                        pictureBoxTamam.Show();
                        MessageBox.Show("Bu emil kayıtlı değil");
                    }
                }
                else
                {
                    pictureBoxTamam.Visible = false;
                    pictureBoxBekle.Visible = true;
      
                    pictureBoxTamam.Show();
                    MessageBox.Show("Şifreler uyuşmuyor");
                }

              
            }
        }

        private void btnSifreKaydet_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSifreKaydet.PerformClick();
        }

        private void ŞifreDeğiştir_Load(object sender , EventArgs e)
        {
          
        }
    }
}
