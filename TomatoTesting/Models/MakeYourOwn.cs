using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class MakeYourOwn
    {
        public int MakeYourOwnId { get; set; }
        public string Sauce { get; set; }
        public string Crust { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public string Topping4 { get; set; }
        public string Topping5 { get; set; }
        public string Topping6 { get; set; }

        //public ICollection<MakeYourOwnTopping> MakeYourOwnToppings { get; set; }
    }
}
