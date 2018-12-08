using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "Thank you, Next by Ariana Grande", "Happier by Marshmellow & Bastille", "Without me by Halsey", "High Hopes by Panic! at the Disco", "Sicko Mode by Travis Scott" };
            Console.WriteLine("Pick a number between 0 and 4 for a song suggestion.");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice > 4)
            {
                Console.WriteLine("Something is wrong. We are not able to suggest a song. This will make the rest of the questions confusing.");
            }
            else
            {
            Console.WriteLine(stringArray[choice]);
                //Console.ReadLine();
            }

            int[] intArray = { 25, 50, 15, 100, 5 };
            Console.WriteLine("Pick a number between 0 and 4 to find out how many stops on their tour they have in 2019");
            int pick = Convert.ToInt16(Console.ReadLine());
            if (choice > 4)
            {
                Console.WriteLine("Something is wrong. We are not able to show you the number of tour stops.");
            }
            else
            { 
                Console.WriteLine(intArray[pick] + " cities in 2019");
                //Console.ReadLine();
            }
            List<string> stringList = new List<string>();
            stringList.Add("New York, NY");
            stringList.Add("Chicago, IL");
            stringList.Add("Denver, CO");
            stringList.Add("Los Angeles, CA");
            stringList.Add("Miami, FL");
            Console.WriteLine("Choose a number between 0 and 4 to view a sold-out city");
            int selection = Convert.ToInt16(Console.ReadLine());
            if (choice > 4)
            {
                Console.WriteLine("Something is wrong. We are not able to show you a sold-out city.");
            }
            else
            {
                Console.WriteLine(stringList[selection]);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
