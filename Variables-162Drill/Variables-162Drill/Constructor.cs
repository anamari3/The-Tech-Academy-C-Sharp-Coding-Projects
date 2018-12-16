using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_162Drill
{
    public class Constructor
    {
        public Constructor (int numCoffees): this ("Drip Coffee", numCoffees)
        {

        }

        public Constructor (string coffeeFlav, int numCoffees)
        {
            CoffeeFlavor = coffeeFlav;
            AvailiableCoffees = numCoffees;
        }

        public string CoffeeFlavor { get; set; }
        public int AvailiableCoffees { get; set; }
    }
}
