using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MigratingFromRazor.Models;
using MigratingFromRazor.DataAccess;

namespace MigratingFromRazor.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            using (BakeryContext context = new BakeryContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(int id)
        {
            using (BakeryContext context = new BakeryContext())
            {
                return context.Products.Find(id);
            }
        }        
    }
}