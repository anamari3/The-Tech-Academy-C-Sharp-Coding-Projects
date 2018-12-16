using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\Student\testfile.txt", text); //uses a file path
            //string text = File.ReadAllText(@"C:\Users\Student\testfile.txt"); //reads text file

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearofGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearofGraduation - yearOfBirth; //result in days


            //Player newPlayer = new Player("Jesse"); //utiiling constructor chain
            //var newPlary = new Player("Jesse"); //using var


            const string casinoName = "Gran hotel and Casino"; //creating and using constant (see below on first line of code "welcome..")


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //constructor (see Player.cs) and initialized it with above inputs
                player.Id = Guid.NewGuid(); //identifer for all new users. globally unique
                using (StreamWriter file = new StreamWriter(@"C:\Users\Student\testfile.txt", true))
                {
                    file.WriteLine(player.Id); //logging 
                }
                Game game = new TwentyOneGame();//polymorph to expose overload opperators we made
                game += player;
                player.isActivielyPlaying = true;
                while (player.isActivielyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
               
        }

    }
}
