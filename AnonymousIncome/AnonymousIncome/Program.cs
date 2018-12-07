using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("What is Person 1's hourly rate?");

            double p1rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("How many hours per week does Person 1 work?");

            double p1wkhr = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Person 2");
        Console.WriteLine("What is Person 2's hourly rate?");

            double p2rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("How many hours per week does Person 2 work?");

            double p2wkhr = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Annual salary of Person 1:");

            double p1annual = p1rate * p1wkhr * 52;
        Console.WriteLine(p1annual);

        Console.WriteLine("Annual salary of Person 2:");

             double p2annual = p2rate * p2wkhr * 52;
        Console.WriteLine(p2annual);

        Console.WriteLine("Does Person 1 make more money than Person 2?");

            bool p1Morep2 = Convert.ToBoolean(p1annual > p2annual);

        Console.WriteLine(p1Morep2);

        Console.ReadLine();
    }
}

