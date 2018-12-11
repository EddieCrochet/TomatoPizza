using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class Topping
    {
        public int ToppingId { get; set; }
        public string Name { get; set; }
        //public ICollection<MakeYourOwnTopping> MakeYourOwnToppings { get; set; }
    }
}
