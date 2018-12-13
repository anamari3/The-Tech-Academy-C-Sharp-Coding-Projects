using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_Drill
{
    public class Operation
    {
        public int Math(int num1)
        {
            int result = num1 * num1;
            Console.WriteLine(num1 + " to the second power is " + result);
            return result;

        }

        public int Math (decimal num2)
        {
            int new2 = decimal.ToInt32(num2);
            int result = new2 / 3;
            Console.WriteLine(num2 + " divided by 3 equals " + result);
            return result;
        }

        public string Math (string num3)
        {
            int new3 = Convert.ToInt32(num3);
            int result = new3 + 20;
            string stringResult = Convert.ToString(result);
            Console.WriteLine(new3 + " plus 20 equals " + result);
            return stringResult;
        }
    }
}
