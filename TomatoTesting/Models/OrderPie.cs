using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class OrderPie
    {
       [Key]
        public string OrderPieId { get; set; }
        public string CustomerId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
    }
}
