using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemID { get; set; }
        public Order Order { get; set; }
        public int? OrderID { get; set; }
        public int? PizzaID { get; set; }
        public Pizza Pizza { get; set; }
        public int? MakeYourOwnID { get; set; }
        public MakeYourOwn MakeYourOwn { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public double? Price
        {
            get
            {
                return GetPrice();
            }
        }

        public double GetPrice()
        {
            double price = 0;
            if (Pizza != null)
            {
                if (Size == 8)
                {
                    price = Pizza.EightInchPrice * Number;
                }
                else if (Size == 10)
                {
                    price = Pizza.TenInchPrice * Number;
                }
                else if (Size == 12)
                {
                    price = Pizza.TenInchPrice * Number;
                }
                else if (Size == 14)
                {
                    price = Pizza.TenInchPrice * Number;
                }
                else if (Size == 16)
                {
                    price = Pizza.TenInchPrice * Number;
                }
                else if (Size == 18)
                {
                    price = Pizza.TenInchPrice * Number;
                }
            }
            else if (MakeYourOwn != null)
            {
                if (Number > 0)
                {
                    price = (8.95 + MakeYourOwn.NumberToppings) * Number;
                }
            }
            else
            {
                price = 0;
            }
            return price;
        }
    }
}
