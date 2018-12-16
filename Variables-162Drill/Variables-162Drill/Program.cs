using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_162Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "Olympia Coffee Roasters";

            Console.WriteLine("Good morning! Welcome to {0}. How many drinks would you like today?", companyName);
            var coffee = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(coffee + " coffees coming right up!");
            Console.ReadLine();
        }
    }
}
