using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_115Drill
{
    class Program
    {
        public static void Main(string[] args)
        {
            Parameters parameters = new Parameters(); //instantiate
            Console.WriteLine("Give me a number:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a second number: (Optional: Type Enter to forego giving another number)");
            string numB = Console.ReadLine();
            int x;
            if (int.TryParse(numB, out x))
                {
                int newName = parameters.Math(num1: numA, num2: x);
                Console.WriteLine("The sum of those two numbers is " + newName);
                }
            else
            {
                int result = parameters.Math(num1: numA);
                Console.WriteLine("The sum of " + numA + " and 5 is " + result);

            }
        
            
            Console.ReadLine();
        }
    }
}