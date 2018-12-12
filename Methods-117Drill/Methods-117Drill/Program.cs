using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_117Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod drill = new VoidMethod(); //instantiate
            Console.WriteLine("Enter a number:");
            ////string name = Console.ReadLine();
            //decimal number = string.ToInt32(Console.ReadLine());
            int number = Convert.ToInt32(Console.ReadLine());

            drill.Divide(num1: number); //call the method
            drill.Divide(num2: number);
            drill.Divide(num3: number);
            drill.outParam(number: out number);
            Console.ReadLine();
        }
    }
}
