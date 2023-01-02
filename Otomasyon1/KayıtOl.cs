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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

       
        PersonDal person = new PersonDal();
        private void btnKayıtOl_Click(object sender , EventArgs e)
        {
           // Alanlar Boş Bırakılmamassı için 
            if(tbxklcİsminiz.Text.Equals("")|| tbxklnKullanıcıAdı.Text.Equals("") || tbxklnŞİfre.Text.Equals(""))
            {
                MessageBox.Show("Lütfen Alanları Doldurun");
               
            }
            // Mailin doğru biçimde girildiğini kontrol etme
            else if (!tbxklnKullanıcıAdı.Text.Contains("@gmail.com") )
            {
                MessageBox.Show("Lütfen geçerli bir eposta giriniz");
            }
            else
             {
                // Kontrolu PersonDal da yaptık is here metodu ile
                person.isHere(tbxklnKullanıcıAdı.Text,tbxklnŞİfre.Text);
                if (person.ishere)
                {
                    MessageBox.Show("Bu E posta Önceden " +
                        "önce alınmış");
                }
                else
                {
                    person.Add(new Person
                    {
                        Name = tbxklcİsminiz.Text ,
                        Email = tbxklnKullanıcıAdı.Text ,
                        Password = tbxklnŞİfre.Text

                    });
                    MessageBox.Show("Kayıt Olundu");
                }
                    
            }
        


        }

        private void btnKayıtOl_KeyDown(object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKayıtOl.PerformClick();
        }
    }
}
