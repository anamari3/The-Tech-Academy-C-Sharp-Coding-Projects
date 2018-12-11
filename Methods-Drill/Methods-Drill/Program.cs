using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Drill
{
    class NumberManipulator
    {
        //public int FindMax(int num1, int num2)
        //{
        //    int result;
        //    if (num1 > num2)
        //        result = num1;
        //    else
        //        result = num2;
        //    return result;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number:");
            int numB = Convert.ToInt32(Console.ReadLine());
            int ret;
            int sum;
            int multiply;
            NumbersManipulator n = new NumbersManipulator();

            ret = n.FindMax(numA, numB);
            Console.WriteLine("Max value is: {0}", ret);

            sum = n.Adding(numA, numB);
            Console.WriteLine("The sum is: {0}", sum);

            multiply = n.Multiplication(numA, numB);
            Console.WriteLine("The multiplication of these two numbers is: {0}", multiply);
            Console.ReadLine();

        }
    }
}