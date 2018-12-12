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
            int numB = Convert.ToInt32(Console.ReadLine());
            int result;
            int resultAlt;

            result = parameters.Math(num1: numA, num2: numB);
            resultAlt = parameters.Math(num1: numA, num2 = 5);

            Console.WriteLine("The sum of those two numbers is: {0}", result);

            Console.ReadLine();
        }
    }
}
