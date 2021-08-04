using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// refactoring is going over old code and making it more efficient and more readable
// objects are items that can be represented by a computer program


// an analogy for the difference between a class and an object:
// a class would be the cookie cutter and a object would be the cookie

namespace TwentyOne
{
    class Program
    {
        // Mehtods, also called functions or routines, are little blocks of reusuable code
        // composed of an access modifier, a return type, and contain parameters or lack of parameters
        // methods have to be part of the a class
        // if a method is being used without first creating an object of that class it must be marked as static
        static void Main(string[] args)
        {
            //// POLYMORPHISM
            //// one object, TwentyOneGame, can morph into a higher order object, Game.
            //// possible because TwentyOneGame inherits from Game
            //Game game = new TwentyOneGame();

            //// Using polymorphism you would be able to create a list of games that encompass all of the games though they are technically different datatypes
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame();
            //games.Add(game);


            //// Deck has a property called "Cards" which is a datatype List
            //// in order to assign anything to a list you must instantiate a new List
            //deck.Cards = new List<Card>();


            //// create card object
            //// an object of datatype Card assigned to the variable cardOne
            //Card cardOne = new Card();
            //// assign the object some values
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            // OBJECT INITIALIZATION
            //Card card = new Card() { Face = "Queen", Suit = "Spades" }; 

            //// typing every card one by one would be very tedious and very time consuming
            //// a contructor would be better
            //deck.Cards.Add(cardOne);

            //Game game = new Game();
            //game.Players = new List<string> { "Jesse", "Bill", "Joe", };
            //// Super Class Method: when you call a method from class you're inheriting from
            //game.ListPlayers();
            //Console.ReadLine();

            /*** overloading operators ***/
            //Game game = new TwentyOneGame();
            //// need to instantiate a list to add players to it
            //game.Players = new List<Player>();
            //// Deck is the datatype
            //// deck is the variable

            //Player player = new Player();
            //player.Name = "Jesse";
            ////  parameters are game and player returns a game
            //game += player;
            //game -= player;

            /***
            // enums limit the possible values you can recieve from a user
            DaysOfTheWeek day = DaysOfTheWeek.Monday;
            ***/

            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //// casted Suit.Diamonds to an integer can also be written like "Convert.ToInt32(Suit.Diamonds)"
            /// enums also have a underlying value of integer
            //int underlyingValue = (int)Suit.Diamonds;
            //Console.WriteLine(underlyingValue);

            Deck deck = new Deck();

            //// call the method
            //deck = Shuffle(deck);
            ////you can add the named parameter to make it more readable
            //deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            //instead of writing the above write:
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string> { "Jesse", "Bill", "Bob", };
            //game.ListPlayers();
            //Console.ReadLine();
        }
        
        //// an Enum is One in a set of named constants
        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}


        // want a method that takes a list of cards and shuffles them
        // takes in a deck and returns a deck

        // public because we want this accessible everywhere in the program
        // static because we don't want to create an object in Program before calling this
        // Deck is the datatype it is returning
        // Shuffle is the name of the function
        // takes a parameter of type: Deck and variable name: deck
        
        // instead of overloading a method you can make the times parameter optional
        // by setting a default value of one you create a OPTIONAL VALUE

        // an out parameter
        // has to go before any optional parameter
        

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);

        //    }
        //    return deck;
        //}
    }
}

// Method overloading
// C# allows methods that all have the same number as long as each method is "kinda different"
// the compiler has specific rules on which method to use but if it get confused it gives an error
// 