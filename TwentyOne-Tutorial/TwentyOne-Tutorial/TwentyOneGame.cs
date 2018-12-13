using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Tutorial
{
    public class TwentyOneGame : Game //this is being inhereted
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
    }
}
