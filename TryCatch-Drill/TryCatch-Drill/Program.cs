using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Drill
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                List<int> numbers = new List<int> { 10, 22, 34, 46, 58, 60, 72, 84, 96 };
                List<int> picks = new List<int>();
                Console.WriteLine("Pick a number between 1 and 100");
                int pick = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    picks.Add(number / pick);
                }
                foreach (int added in picks)
                {
                    Console.WriteLine("My number divided by " + pick + " = " + added);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero");
            }
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
            Console.ReadLine();
        }
    }
}
