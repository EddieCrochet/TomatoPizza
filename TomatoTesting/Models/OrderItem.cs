using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
        public Pizza Pizza { get; set; }
        public MakeYourOwn MakeYourOwn { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
    }
}
