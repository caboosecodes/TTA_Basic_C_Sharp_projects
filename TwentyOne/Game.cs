using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // Abstract Class (base class)
    // class marked with the keyword abstract
    // class that is never instantiated, only inherited from
    
    // generic name Game
    // Design towards abstraction
    // the more generic you can make your code the easier it is to add features to it later
    public abstract class Game
    {
        // you have to instantiate a list so that it is never null
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        
        // get and set is a shorthand
        public List<Player> Players { get { return _players;  } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        
        // Abstract Method
        // Abstract method can only exist inside of an abstract class
        // contains no implementation
        // any class inheriting this class MUST implement this method
        public abstract void Play();

        // Virtual Keyword (Virtual Method)
        // Virtual methods are inside abstract classes
        // Virtual methods HAVE IMPLEMENTATION but can be overwritten (rewrite or add on to it)
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
