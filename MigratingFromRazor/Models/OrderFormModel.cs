using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MigratingFromRazor.Models
{
    public class OrderFormModel
    {
        public int Product { get; set; }
        public int OrderQty { get; set; }

        [Required]
        public string OrderShipping { get; set; }

        [Required(ErrorMessage ="You must provide an email address.")]
        public string OrderEmail { get; set; }
    }
}