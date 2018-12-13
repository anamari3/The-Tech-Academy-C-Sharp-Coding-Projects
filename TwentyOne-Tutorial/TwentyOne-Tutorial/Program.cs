using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Game game = new TwentyOneGame(); //POLYMORPHISM
            ////game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            ////game.ListPlayers();
            ////Console.ReadLine();
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player;
            //game -= player;

            //Card card = new Card(); //DEMONSTRATE ENUM
            //card.Suit = Suits.Clubs;
            //int underlyingValue = Convert.ToInt32(Suits.Diamonds);

           Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

    }
}
