using MigratingFromRazor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MigratingFromRazor.DataAccess
{
    public class BakeryContext : DbContext
    {
        public BakeryContext() : base() { }

        public DbSet<Product> Products { get; set; }
    }
}