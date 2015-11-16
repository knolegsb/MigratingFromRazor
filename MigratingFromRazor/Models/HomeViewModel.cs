using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigratingFromRazor.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public Product Featured
        {
            get { return Products[new Random().Next(Products.Count)]; }
        }
    }
}