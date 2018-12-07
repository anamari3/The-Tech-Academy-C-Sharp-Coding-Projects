using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ana";
            //string quote = "The man said, \"Hello\", Ana. \n Hello on a new line. \n \t Hello on a tab \\Hello";
            ////string fileName = "C:\\Users\\Ana";
            //string fileName = @"C:\Users\Ana";

            //bool trueOrFale = name.Contains("s");
            //trueOrFale = name.EndsWith("s");

            //int length = name.Length;

            ////name = name.ToUpper();
            //name = name.ToLower();


            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Ana";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Ana");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
