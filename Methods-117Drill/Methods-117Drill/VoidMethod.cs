using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_117Drill
{
    class VoidMethod
    {
        public void Divide(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("Half of " + num1 + " is " + result);
        }

        public void Divide(decimal num2)
        {
            int new2 = decimal.ToInt32(num2);
            int result = new2 / 10;
            Console.WriteLine(num2 + " divided by 10 is " + result);
        }

        public void Divide (float num3)
        {
            int new3 = Convert.ToInt32(num3);
            int result = new3  / 5;
            Console.WriteLine(num3 + " divided by 5 is: "+ result);
        }

        public void outParam (out int number)
        {
            number = 44;
            Console.WriteLine(number);
        }

        static void Divide(string num4)
        {
            int new4 = Convert.ToInt32(num4);
            int result = new4 / 3;
            Console.WriteLine(num4 + " divided by 3 is: " + result);

        }
    }
}
