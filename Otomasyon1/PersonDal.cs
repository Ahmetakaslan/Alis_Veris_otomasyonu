using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon1
{
    internal class PersonDal
    {
        public static bool kayıtvarmı = false;
       public bool ishere = false;
        public List<Person> GetAll()
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Person.ToList();
            }

        }
      
        public void Add(Person person)
        {
            using (ProductContext context = new ProductContext())
            {

                context.Person.Add(person);
                context.SaveChanges();

            }

        }
        public void Delete(Person person)
        {
            using (ProductContext context = new ProductContext())
            {
                var entity = context.Entry(person);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Person person)
        {
            using (ProductContext context = new ProductContext())
            {

                var entity = context.Entry(person);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public List<Person> Search(string key)
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Person.Where(p => p.Name.Contains(key)).ToList();

            }
        }
        public void SearchRecord(string Name , string şifre)
        {
            using (ProductContext context = new ProductContext())
            {
                if (context.Person.FirstOrDefault(p => p.Email.Equals(Name) && p.Password.Equals(şifre))==null)
                 
                {
                    MessageBox.Show("Kaydınız bulunmamaktadır");
                    kayıtvarmı = false;
                }
                else
                { 
                    kayıtvarmı = true;
                }
            }
        }

        // birinin öncceden kayıtlı opup olmdığını kontrol ediyoruz
        public  void isHere(string kullanıcıAdı,string şifre)
        {
           
            using (ProductContext context =new  ProductContext())
            {
               if( context.Person.FirstOrDefault(p => p.Email.Equals(kullanıcıAdı)) != null  )
                {
                    ishere = true;
                }
              
                else
                {
                    ishere=false;
                }
            }  
        }
      public List<Person> searchName(String name)
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Person.Where(p => p.Name.Contains(name)).ToList();
            }
        }


    }
}
