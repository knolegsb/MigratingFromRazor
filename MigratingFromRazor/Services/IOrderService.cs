using MigratingFromRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingFromRazor.Services
{
    public interface IOrderService
    {
        void ProcessOrder(Order order);
    }
}
