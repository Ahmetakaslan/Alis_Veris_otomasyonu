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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otomasyon1
{
    public partial class FormGirisYap : Form
    {
        // burası şifreyi göster gizle kısmı içi kontrol görevi görüyor
        bool EmailDogruMu=false;
        public static string email;
        public static string kullaniciAdi;
        public FormGirisYap()
        {
            InitializeComponent();
        }

        private void FormGirisYap_Load(object sender , EventArgs e)
        {
  
        }
        string kullanıcıAdı = "Akaslan";
        string şifre = "0463";
        public bool textChange = false;
        public static string tempKullanıcıAdı = "";
        public static string tempSifre = "";



        private void tbxKullanıcıadı_TextChanged(object sender , EventArgs e)
        {
            isChange();
        }
        public void isChange()
        {
            // Burada text Change eventini kullanıyorum text istediğin gibi değişirse 
            // bunları yapabilirsin
            if (tbxKullanıcıadı.Text.Equals("Akaslan") && tbxŞifre.Text.Equals("0463"))
            {
                KullaniciVerileri kullaniciVerileri = new KullaniciVerileri();
                this.Hide();
                kullaniciVerileri.ShowDialog();
                this.Show();
            }
        }


  
        private void tbxŞifre_TextChanged_1(object sender , EventArgs e)
        {
            isChange();
           // controlPassword(this.lblSifreTick);
        }

     

        private void btnGirisYap_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap.PerformClick();
        }

        //public void controlEmail(Label name)
        //{
        //    Person b = mainQuery();
        //    if (b == null)
        //    {
        //        EmailDogruMu = false;
        //        name.Text = "\u2718";
        //        name.Size = new Size(40 , 40);
        //        name.ForeColor = Color.Black;

        //        //labeltick.Text = ((char)0x2713).ToString();
        //    }
        //    else
        //    {
        //        if (b.Email != null)
        //        {
        //            EmailDogruMu=true;
        //            name.Text = "\u221A";
        //            name.Size = new Size(40 , 40);
        //            labeltick.ForeColor = Color.Green;
        //        }
        //        else
        //        {
        //            EmailDogruMu = false;
        //            name.Text = "\u2718";
        //            name.Size = new Size(40 , 40);
        //            name.ForeColor = Color.Black;

        //            //labeltick.Text = ((char)0x2713).ToString();
        //        }
        //    } 
        //}
        //public void controlPassword(Label name)
        //{
        //    Person b = mainQuery();
        //    if (EmailDogruMu == false)
        //    {
        //        //çarpı
        //        name.Text = "\u2718";
        //        name.Size = new Size(40 , 40);
        //        name.ForeColor = Color.Black;

        //        //labeltick.Text = ((char)0x2713).ToString();
        //    }
        //    else
        //    {
        //        if (b.Password.Equals(tbxŞifre.Text))
        //        {
        //            // tick

        //            name.Text = "\u221A";
        //            name.Size = new Size(40 , 40);
        //            labeltick.ForeColor = Color.Green;
        //        }
        //        else
        //        {
        //            //Çarpı
        //            name.Text = "\u2718";
        //            name.Size = new Size(40 , 40);
        //            name.ForeColor = Color.Black;

        //            //labeltick.Text = ((char)0x2713).ToString();
        //        }
        //    }
          

        //}

        //private void tbxKullanıcıadı_TextChanged_1(object sender , EventArgs e)
        //{
        //    controlEmail(this.lblPostaTick);
        //}
        private Person mainQuery()
        {
                ProductContext product = new ProductContext();
              Person b = product.Person.Where(p => p.Email.Equals(tbxKullanıcıadı.Text)).FirstOrDefault<Person>();
            if(b== null)
            {
                Person c = new Person() { Email=null,Password=null};
                return c;
            }
            else
            {
                return b;
            }
             
            
           
        }

       
     



        private void btnKayıtOl_Click(object sender , EventArgs e)
        {
            KayıtOl kayıt = new KayıtOl();
            this.Hide();
            kayıt.ShowDialog();
            this.Show();
        }

     


  
        private void btnGirisYap_Click_1(object sender , EventArgs e)
        {
            if (tbxKullanıcıadı.Text.Equals("") || tbxŞifre.Text.Equals(""))
            {
                MessageBox.Show("Alanlar boş bırakılamaz");
            }
            else
            {
                if (!tbxKullanıcıadı.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Lütfen Email formatında giriş yapın");
                }
                else
                {

                    PersonDal person = new PersonDal();
                    person.SearchRecord(tbxKullanıcıadı.Text , tbxŞifre.Text);

                    if (PersonDal.kayıtvarmı)
                    {
                        ProductContext product = new ProductContext();


                        // buranda bir filitreleme olacak
                        if (FormAnaSayfa.Tıklandı == true)
                        {
                            tempKullanıcıAdı = tbxKullanıcıadı.Text;
                            tempSifre = tbxŞifre.Text;
                            email = tbxKullanıcıadı.Text;
                            kullaniciAdi = product.Person.SingleOrDefault(p => p.Email.Equals(tbxKullanıcıadı.Text) && p.Password.Equals(tbxŞifre.Text)).Name;
                            FormÜrünAl form = new FormÜrünAl();
                            form.isimUrunAl = "Hoş Geldiniz " + product.Person.SingleOrDefault(p => p.Email.Equals(tbxKullanıcıadı.Text) && p.Password.Equals(tbxŞifre.Text)).Name + " Bey";
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            email = tbxKullanıcıadı.Text;
                            FormÜrünSat form = new FormÜrünSat();
                            form.isimUrunSat = "Hoş Geldiniz " + product.Person.SingleOrDefault(p => p.Email.Equals(tbxKullanıcıadı.Text) && p.Password.Equals(tbxŞifre.Text)).Name + " Bey";
                            this.Hide();
                            form.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ilkin kayıt yaptırın");
                        KayıtOl kayıt = new KayıtOl();
                        this.Hide();
                        kayıt.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void btnKayıtOl_Click_1(object sender , EventArgs e)
        {
            KayıtOl kayıt = new KayıtOl();
            this.Hide();
            kayıt.ShowDialog();
            this.Show();
        }

        private void admin_Click(object sender , EventArgs e)
        {
            if (tbxKullanıcıadı.Text.Equals(kullanıcıAdı) && tbxŞifre.Text.Equals(şifre))
            {
                KullaniciVerileri kullanici = new KullaniciVerileri();
                this.Hide();
                kullanici.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Yönetici giriş hatalı");
            }
        }

        private void btnGözKapa_Click(object sender , EventArgs e)
        {
            btnGözKapa.Visible = false;
            // burada uft 16 ya göre null ve '' atanamaz bunların karşılığı olan 
            // '\0' atanır
            tbxŞifre.PasswordChar = '\0';
            btnGozAc.Visible = true;
        }

        private void btnGozAc_Click(object sender , EventArgs e)
        {
            btnGözKapa.Visible = true;
            tbxŞifre.PasswordChar = '*';
            btnGozAc.Visible = false;
        }

        private void linkLabel1_LinkClicked_1(object sender , LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SifreKurtar verify = new SifreKurtar();
            verify.ShowDialog();
            this.Show();


        }

        private void roundedPanel1_Paint(object sender , PaintEventArgs e)
        {

        }

        private void btnGirisYap_KeyDown_1(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap.PerformClick();
        }
    }
}
