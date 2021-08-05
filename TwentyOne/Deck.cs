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

            // want to loop through all 13 faces
            for (int i = 0; i < 13; i++)
            {
                // for each face we loop through each suit
                for (int j = 0; j < 4; j++)
                {
                    // create a new card
                    Card card = new Card();
                    // assign the card a face
                    // casting an integer, i, TO Face
                    card.Face = (Face)i;
                    // casting an integer, j, TO Suit
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            /*** COMMENTED OUT BECAUSE OF ENUM

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
                //foreach(string suit in Suits)
                //{
                //    // this card variable only exists inside the loop
                //    Card card = new Card();
                //    card.Suit = suit;
                //    card.Face = face;
                //    Cards.Add(card);
                //}
            }
            ***/

            //// this would be tedious to type over and over again
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


        }

        // a deck is a collection of cards
        //private List<Card> _card = new List<Card>();
        public List<Card> Cards { get; set; }

        // static allows a method without it applying to the object
        // void 
        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                // to store our shuffled item 
                List<Card> tempList = new List<Card>();

                // shuffling is supposed to be random
                // random class from the framework class library
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    // selects a random card from the index of deck
                    int randomIndex = random.Next(0, Cards.Count);
                    // places that random card in the tempList
                    tempList.Add(Cards[randomIndex]);
                    // removes that card from deck list
                    // RemoveAt is a function of the List type
                    Cards.RemoveAt(randomIndex);
                }
                // sets the empty deck equal to the tempList
                Cards = tempList;
            }
        }
    }
}
