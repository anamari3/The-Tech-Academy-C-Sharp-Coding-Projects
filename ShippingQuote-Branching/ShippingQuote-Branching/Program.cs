using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());
        if (weight > 50m)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            if ((width + height + length) > 50m)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal quote = (((width + height + length) * weight) / 100.00m);
                Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
            }
        }
        Console.WriteLine("Thank you.");
        Console.ReadLine();
}   
    }

