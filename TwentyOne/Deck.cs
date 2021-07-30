using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // Constructors always go on the top of the class before the properties
        public Deck()
        {
            // Cards is referring to the property of the class
            Cards = new List<Card>();
            // nested foreach loop
            // create a list of all the possible suits
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades", };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight","Nine", "Ten", "Jack","Queen","King","Ace"
            };

            foreach (string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    // this card variable only exists inside the loop
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }




            //// this would be tedious to type over and over again
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


        }

        // a deck is a collection of cards
        public List<Card> Cards { get; set; }
    }
}
