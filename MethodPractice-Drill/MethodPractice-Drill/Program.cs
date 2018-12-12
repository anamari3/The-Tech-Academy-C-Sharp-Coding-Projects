using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice_Drill
{
      class Program
    {
        public static void Main(string[] args)
        {
         Math madeUpName = new Math();
          //madeUpName.DoMath(a,b);

            Console.WriteLine("Pick a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number:");
            int b = Convert.ToInt32(Console.ReadLine());

            madeUpName.DoMath(num1: a, num2: b);
            Console.ReadLine();
        }
    }
}
