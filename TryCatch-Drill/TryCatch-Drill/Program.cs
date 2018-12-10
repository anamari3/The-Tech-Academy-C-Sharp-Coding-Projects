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
            List<int> numbers = new List<int> { 10, 22, 34, 46, 58, 60, 72, 84, 96 };
            Console.WriteLine("Pick a number between 1 and 100");
            int pick = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++) ; //THIS IS WRONG
            if (pick > 1)
            {
                int quotient = (numbers[i] / pick);
                //Console.WriteLine(numbers[i] + " divided by " + pick);
            }
            Console.ReadLine();
        }
    }
}
