using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI?");
        string x = Console.ReadLine();
            bool dui = new bool();
            if (x == "yes" || x == "y" || x == "yeah")
            {
                dui = true;
            }
            else
            {
                dui = false;
            }

        Console.WriteLine("How many speeding tickets do you have?");

        int tickets = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qualified?");
        bool agequalified = Convert.ToBoolean(age > 15);
        bool duiqualified = dui == false;
        bool ticketsqualified = Convert.ToBoolean(tickets <= 3);

        Console.WriteLine(agequalified && duiqualified && ticketsqualified);
        Console.ReadLine();
        }
    }

