using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gernerics_131Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() { "pen", "paper", "keyboard", "monitor" };

            Employee<int> employ = new Employee<int>();
            employ.things = new List<int>() { 2, 4, 6, 8, 10 };

            foreach (Employee<string> thing in employee.things)
            {
                foreach (Employee<int> things in employ.things)
                {
                    Console.WriteLine(thing);

                }
                Console.ReadLine();
            }
            //Class_124Drill.IQuittable employee = new Class_124Drill.Employee();
            ////employee<T> employee = new Employee<T>();
            ////employee.firstName = "Sample";
            ////employee.lastName = "Student";
            ////employee.SayName();
            //employee.Quit();
        }
    }
}
