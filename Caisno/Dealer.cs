using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    // Inheritance is a "is a" relationship NOT a "has a" relationship
    // a Dealer HAS A Deck, a dealer IS NOT A Deck
    // TwentyOneGame IS A Game,  TwentyOneGame does "have a" game
    public class Dealer
    {
        // properties
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        // methods
        public void Deal(List<Card> Hand)
        {
            // Hand is a List
            // built in method Add
            // Deck is a property, a list of Cards
            // First is a method available to a list that grabs the first item into a list
            Hand.Add(Deck.Cards.First());

            //want to log 
            string card = string.Format(Deck.Cards.First().ToString() + "\n");

            // prints the card to the console
            Console.WriteLine(card);

            // appends to the log
            // true means it wants to append, false would mean create a new file
            using (StreamWriter file = new StreamWriter(@"C:\Users\Ricar\Desktop\twentyoneIO\log.txt", true))
            {
                // DateTime.Now gives the exact datetime object of this moment
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            // RemovesAt() is a method available to a list that removes a element at a given index
            Deck.Cards.RemoveAt(0);

        }
    }
}
