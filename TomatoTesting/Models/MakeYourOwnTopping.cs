using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TomatoPizzaCafe.Models
{
    public class MakeYourOwnTopping
    {
        public int MakeYourOwnId { get; set; }
        public MakeYourOwn MakeYourOwn{ get; set; }
        public int ToppingId { get; set; }
        public Topping Topping { get; set; }
    }
}
