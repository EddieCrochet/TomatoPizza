using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class MakeYourOwn
    {
        public int MakeYourOwnID { get; set; }
        public string Sauce { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }
        public string Topping6 { get; set; }
        public int NumberToppings
        {
            get
            {
                return CountToppings();
            }
        }
        public int? OrderID { get; set; }
        public Order Order { get; set; }

        public int CountToppings()
        {
            int count = 0;
            if (Topping1 != null)
                count += 1;
            if (Topping2 != null)
                count += 1;
            if (Topping3 != null)
                count += 1;
            if (Topping4 != null)
                count += 1;
            if (Topping5 != null)
                count += 1;
            if (Topping6 != null)
                count += 1;
            return count;
        }
    }
}
