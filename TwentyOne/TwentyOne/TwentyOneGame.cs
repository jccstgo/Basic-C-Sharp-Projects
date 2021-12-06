using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play() 
        {
            Console.WriteLine("Some text");
            throw new NotFiniteNumberException();
        }

        public override void ListPlayers() 
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
    }
}
