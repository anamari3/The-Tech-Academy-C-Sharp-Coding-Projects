using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile_154Drill
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            string number = Console.ReadLine(); //log number to text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\testfile.txt", true))
            {
                file.WriteLine(number);
            }

            string text = File.ReadAllText(@"C:\Users\Student\testfile.txt"); //prints file text back
            Console.WriteLine(text);

            Console.ReadLine();
          
        }
    }
}
