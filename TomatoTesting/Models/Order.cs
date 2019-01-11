using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TomatoPizzaCafe.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public double TotalPrice
        {
            get
            {
                return GetTotalPrice();
            }
        }
        public List<OrderItem> OrderItems { get; set; }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach(var orderItem in OrderItems)
            {
                totalPrice += orderItem.Price;
            }
            return totalPrice;
        }
    }
}
