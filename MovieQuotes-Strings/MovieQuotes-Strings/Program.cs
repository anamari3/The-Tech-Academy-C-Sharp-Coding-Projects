using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            string actorMain = "Arnold Schwarzenegger";
            string actorSupport = "Robert Conrad";
            string charMain = "Howard Langston";
            string charSupport = "Officer Hummell";

            Console.WriteLine("Jingle All the Way");
            Console.WriteLine(charMain + " played by " + actorMain + " and " + charSupport + " played by " + actorSupport);

            charMain = charMain.ToUpper();
            charSupport = charSupport.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(charSupport + ": Turbo Man, we could use a man like you on the force. \n \n" + charMain + ": [In Turbo Man outfit] Thanks, I'll keep that in mind. \n Oh, I'm sorry about the bike, and the coffee, and the bus, and...the bomb. ");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}