using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_156Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Give me a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = (currentTime.AddHours(number));
            Console.WriteLine("In " + number + " hours it will be exactly " + futureTime);
            Console.ReadLine();
        }
    }
}
