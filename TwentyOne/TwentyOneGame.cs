using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // To INHERIT from another class put a semicolon and the name of the calss to inherit from
    public class TwentyOneGame : Game
    {
        // in order to implment the inherited abstract method you have to use override keyword
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            // added to the method
            Console.WriteLine("21 players");
            // automatically put in
            // equivalent to the virtual method in Game
            base.ListPlayers();
        }
    }
}
