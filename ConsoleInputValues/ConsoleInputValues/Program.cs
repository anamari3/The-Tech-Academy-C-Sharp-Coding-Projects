using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Think of a number, any number. What is it?");

        double num1 = Convert.ToDouble(Console.ReadLine());
        double product = num1 * 50;
        Console.WriteLine(num1 + " multiplied by 50 = " + product);
        //Console.ReadLine();
        

        Console.WriteLine("Think of a new number. What is it?");

        double num2 = Convert.ToDouble(Console.ReadLine());
        double sum = num2 + 25;
        Console.WriteLine(num2 + " + 25 = " + sum);
        //Console.ReadLine();

        Console.WriteLine("Give me another number!");

        double num3 = Convert.ToDouble(Console.ReadLine());
        double quotDec = (double)num3 / 12.5;
        Console.WriteLine(num3 + " divided by 12.5 = " + quotDec);
        //Console.ReadLine();

        Console.WriteLine("Another number, please!");

        double num4 = Convert.ToDouble(Console.ReadLine());
        double fifty = 50;
        bool lgrFifty = num4 > fifty;
        Console.WriteLine("Is " + num4 + " greater than 50? " + lgrFifty);
        //Console.ReadLine();

        Console.WriteLine("One last number!");

        double num5 = Convert.ToDouble(Console.ReadLine());
        double remainder = num5 % 7;
        Console.WriteLine("The remainder of " + num5 + " divided by 7 is " + remainder);
        Console.ReadLine();


         
         }
}
