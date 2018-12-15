using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Tutorial
{
    public class Player
    {

        public Player (string name, int beginningBallance) //constructors go at top of class
        {
            Hand = new List<Card>();
            Balance = beginningBallance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivielyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance =- amount;
                return true;
            }
        }

        public static Game operator +(Game game, Player player) //overload operator
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
