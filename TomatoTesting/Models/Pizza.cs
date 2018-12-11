using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public double EightInchPrice{ get; set; }
        public double TenInchPrice { get; set; }
        public double TwelveInchPrice { get; set; }
        public double FourteenInchPrice { get; set; }
        public double EighteenInchPrice { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
    }
}
