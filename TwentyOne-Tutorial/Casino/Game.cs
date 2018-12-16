using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public  abstract class Game
    {
        private List<Player> _players = new List<Player>(); //make sure that the list of players is never null. want to make sure we have at least an instanciated empty list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //this is the same as get; set; but now uses the private list above
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
