using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 17;
            //Console.WriteLine(quotient);
            //Console.ReadLine(); //this rounds to 5

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine(); //even number.

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine(); //odd number.

            //COMPARE OPERATORS

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;

            //bool isWarm = currentTemp > roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp >= roomTemp;
            bool isWarm = currentTemp != roomTemp; //!= means 'not equal'
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
