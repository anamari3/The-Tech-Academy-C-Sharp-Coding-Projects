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
            operation.Math(12);

            operation.Math(100.20m);

            operation.Math("15");

            Console.ReadLine();
            
        }
    }
}
