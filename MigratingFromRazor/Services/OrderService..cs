using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MigratingFromRazor.Models;

namespace MigratingFromRazor.Services
{
    public class OrderService : IOrderService
    {
        public void ProcessOrder(Order order)
        {
            IMailService service = new MailService();
            service.SendOrderConfirmation(order);
        }
    }
}