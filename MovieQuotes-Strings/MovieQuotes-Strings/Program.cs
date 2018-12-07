using System;

    class Program
    {
        static void Main()
        {
        string actorMain = "Arnold Schwarzenegger";
        string actorSupport = "Robert Conrad";
        string charMain = "Howard Langston";
        string charSupport = "Officer Hummell";

        Console.WriteLine("Jingle All the Way");
        Console.WriteLine(charMain + " played by " + actorMain + " and " + charSupport + " played by " + actorSupport);

        charMain = charMain.ToUpper();
        charSupport = charSupport.ToUpper();

        Console.WriteLine(charSupport + ": Turbo Man, we could use a man like you on the force. \n \n" + charMain + ": [In Turbo Man outfit] Thanks, I'll keep that in mind. \n Oh, I'm sorry about the bike, and the coffee, and the bus, and...the bomb. ");
        Console.ReadLine();
        }
    }

