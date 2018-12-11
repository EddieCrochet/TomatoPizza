using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public List<MakeYourOwn> MakeYourOwns { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
