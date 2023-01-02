using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon1
{
    // iyileştirmeler :
    // burada Generic Yapı kullanılabilirdi Tek bir sınıftan product ve personları
    // kontrol edilebilirdi  şu anki bilgimle yaptığım çıkarım
    // ama SOLID presniplerine uygunmu Her sınıf bir işi yapar.
    internal class  ProductDal
    {
        public List<Products> GetAll()
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Products.ToList();
                context.SaveChanges();
            }

        }
       
        public void Add(Products products)
        {
            using (ProductContext context = new ProductContext())
            {
                context.Products.Add(products);
                context.SaveChanges();
            }
                // var entity = context.Entry(products);
                // entity.State = EntityState.Added;
             
        }
        public void Update(Products products)
        {
            using (ProductContext context = new ProductContext())
            {
                try
                {
                    var entity = context.Entry(products);
                    entity.State = EntityState.Modified;
                    context.SaveChanges();
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
       
        } 
        public void Delete(Products products)
        {
            using (ProductContext context = new ProductContext())
            {
                var entity = context.Entry(products);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }public List<Products> Search(string key)
        {
            using (ProductContext context = new ProductContext())
            {
               return context.Products.Where(p => p.Name.Contains(key)).ToList();
                
            }
        }
        public  List<Products> seatchWithType(string type)
        {
            using (ProductContext context = new ProductContext())
            {
                return context.Products.Where(p => p.Type.Contains(type)).ToList();

            }
        }
       
        
        
    }
}
