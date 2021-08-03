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
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        
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
