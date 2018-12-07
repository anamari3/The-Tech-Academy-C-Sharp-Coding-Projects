using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Guess which season is my favorite!");
        Console.WriteLine("Type 'A' for Winter, 'B' for Summer, 'C' for Spring, or 'D' for Fall?");

        char guessSeason = Convert.ToChar(Console.ReadLine());
        bool isGuessed = guessSeason == 'D';

        while (!isGuessed)
        {
            switch (guessSeason)
            {
                case 'A':
                    Console.WriteLine("Nope! Too rainy. Guess again!");
                    Console.WriteLine("Type 'A' for Winter, 'B' for Summer, 'C' for Spring, or 'D' for Fall?");
                    guessSeason = Convert.ToChar(Console.ReadLine()); break;
                case 'B':
                    Console.WriteLine("Sunny! But no.");
                    Console.WriteLine("Type 'A' for Winter, 'B' for Summer, 'C' for Spring, or 'D' for Fall?");
                    guessSeason = Convert.ToChar(Console.ReadLine()); break;
                case 'C':
                    Console.WriteLine("Not Spring. Guess again.");
                    Console.WriteLine("Type 'A' for Winter, 'B' for Summer, 'C' for Spring, or 'D' for Fall?");
                    guessSeason = Convert.ToChar(Console.ReadLine()); break;
                case 'D':
                    Console.WriteLine("Yes! I love Fall!");
                    isGuessed = true;
                    break;
                default:
                    Console.WriteLine("No.");
                    break;
            }

        }

        Console.WriteLine("Guess which is the reason I love Fall the most.");
        Console.WriteLine(" Type 1 for Halloween, 2 for Pumpkin Spice Lattes, or 3 for colored leaves");
        int reason = Convert.ToInt32(Console.ReadLine());
        bool isPicked = reason == 1;

        do
        {
            switch (reason)
            {
                case 1:
                    Console.WriteLine("Yes! I go big for Halloween!");
                    isPicked = true;
                    break;
                case 2:
                    Console.WriteLine("They're a a good reason to love Fall, but not my favorite");
                    Console.WriteLine(" Type 1 for Halloween, 2 for Pumpkin Spice Lattes, or 3 for colored leaves");
                    reason = Convert.ToInt32(Console.ReadLine()); break;

                case 3:
                    Console.WriteLine("Those are nice, but not the best");
                    Console.WriteLine(" Type 1 for Halloween, 2 for Pumpkin Spice Lattes, or 3 for colored leaves");
                    reason = Convert.ToInt32(Console.ReadLine()); break;
                default:
                    Console.WriteLine("No.");
                    break;
            }
        }
        while (!isPicked);
        Console.ReadLine();

    }
}

