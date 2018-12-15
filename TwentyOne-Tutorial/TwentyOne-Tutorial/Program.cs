using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text";
            //File.WriteAllText(@"C:\Users\Student\testfile.txt", text); //uses a file path
            string text = File.ReadAllText(@"C:\Users\Student\testfile.txt"); //reads text file


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //constructor (see Player.cs) and initialized it with above inputs
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
