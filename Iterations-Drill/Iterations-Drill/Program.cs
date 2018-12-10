using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise #1
            Console.WriteLine("What is your name?");
            string[] names = { "Ana", "David", "Jonathan", "Megan", Console.ReadLine() };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            ////Exercise #2
            ////while (true)
            ////{
            ////    Console.WriteLine("Looping..."); //infinte loop
            ////}

            ////Exercise #3
            ////while (true)
            ////{
            ////    Console.WriteLine("Looping...");
            ////    if (Console.KeyAvailable)
            ////    {
            ////        break;
            ////    }
            ////}

            //Exercise #4
            int[] array1 = { 12, 34, 28, 5, 98, 93, 29, 13 };
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < 30)
                {
                    Console.WriteLine("The following number is less than 30: " + array1[i]);
                }
            }
            Console.ReadLine();

            //Excercise #5
            int[] array2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            for (int j = 0; j < array2.Length; j++)
            {
                if (array2[j] <= 50)
                {
                    Console.WriteLine("This is a numbers in the array that is 50 or less: " + array2[j]);
                }
            }
            Console.ReadLine();

            ////Excersize #6
            ////List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ////Console.WriteLine("In which month is your birthday? Please use the abbreviation Jan, Feb, Mar, Apr, etc");
            ////string birthMonth = Console.ReadLine();
            ////for (int k = 0; k < months.Count; k++) 
            ////{
            ////    if (months[k] == birthMonth)
            ////    {
            ////        Console.WriteLine(k);
            ////    }
            ////}
            ////Console.ReadLine();

            ////Exercise #7
            ////List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ////    Console.WriteLine("In which month is your birthday? Please use the abbreviation Jan, Feb, Mar, Apr, etc");
            ////    string birthMonth = Console.ReadLine();
            ////    for (int k = 0; k < months.Count; k++)
            ////    {
            ////        if (months[k] == birthMonth)
            ////        {
            ////            Console.WriteLine(k);
            ////    }
            ////        else
            ////        {
            ////            Console.WriteLine("Please make sure you capitalize your month and use the approrpirate abbreviation");
            ////        }
            ////    }
            ////    Console.ReadLine();

            ////Exercise #8
            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Console.WriteLine("In which month is your birthday? Please use the abbreviation Jan, Feb, Mar, Apr, etc");
            string birthMonth = Console.ReadLine();
            for (int k = 0; k < months.Count; k++)
            {
                if (months[k] == birthMonth)
                {
                    Console.WriteLine(k);
                    break;
                }
                else
                {
                    Console.WriteLine("Please make sure you capitalize your month and use the approrpirate abbreviation");
                }
            }
            Console.ReadLine();

            ////Exercise #9
            ////List<string> sceduleDays = new List<string>() { "Monday", "Wednesday", "Friday", "Monday" };
            ////Console.WriteLine("Type Monday");
            ////string monday = Console.ReadLine();
            ////for (int m = 0; m < sceduleDays.Count; m++)
            ////{
            ////    if (sceduleDays[m] == monday)
            ////    {
            ////        Console.WriteLine(m);
            ////    }
            ////}
            ////Console.ReadLine();

            ////Exercise #10
            //List<string> sceduleDays = new List<string>() { "Monday", "Wednesday", "Friday", "Monday" };
            //Console.WriteLine("Type Monday");
            //string monday = Console.ReadLine();
            //for (int m = 0; m < sceduleDays.Count; m++)
            //{
            //    if (sceduleDays[m] == monday)
            //    {
            //        Console.WriteLine(m);
            //    }
            //    if (monday != "Monday")
            //    {
            //        Console.WriteLine("Please make sure to type Monday");
            //    }
            //}
            //Console.ReadLine();

            //Exercise #11
            List<string> days = new List<string>() { "Monday", "Wednesday", "Friday", "Monday","Saturday","Friday","Sunday" };
            List<string> pickDays = new List<string>();
            foreach (string day in days)
            {
                if (!pickDays.Contains(day))
                {
                    pickDays.Add(day);
                    Console.WriteLine(day);
                }
                else
                {
                    Console.WriteLine(day + " is already listed");
                }
            }
            Console.ReadLine();


        }
    }
   
}
