using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCalling_Drill
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operation operation = new Operation(); //instantiate
            operation.Power(12);

            operation.Divide(100.20m);

            operation.Addition("15");

            Console.ReadLine();
            
        }
    }
}
