using MigratingFromRazor.Models;
using System.Collections.Generic;

namespace MigratingFromRazor.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}