using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Gues which season is my favorite!");
        Console.WriteLine("Choose one: Winter, Summer, Spring, or Fall?");

        string guessSeason = Console.ReadLine();
        bool isGuessed = guessSeason == Fall;

        while (!isGuessed)
        {
            switch (guessSeason)
            {
                case Winter:
                    Console.WriteLine("Nope! Too rainy. Guess again!");
                    Console.WriteLine("Choose one: Winter, Summer, Spring, or Fall?");
                    guessSeason = Console.ReadLine();
                    break;
                case Summer:
                    Console.WriteLine("Sunny! But no.");
                    Console.WriteLine("Choose one: Winter, Summer, Spring, or Fall?");
                    guessSeason = Console.ReadLine();
                    break;
                case Spring:
                    Console.WriteLine("Not Spring. Guess again.");
                    Console.WriteLine("Choose one: Winter, Summer, Spring, or Fall?");
                    guessSeason = Console.ReadLine();
                    break;
                case Fall:
                    Console.WriteLine("Yes! I love Fall!");
                    isGuessed = true;
                    break;
                default:
                    Console.WriteLine("No.");
                    break;
            }

        }
    }
    }

