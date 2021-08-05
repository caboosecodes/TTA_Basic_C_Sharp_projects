using System;
using System.IO;
using Casino;
using Casino.TwentyOne;


// refactoring is going over old code and making it more efficient and more readable
// objects are items that can be represented by a computer program
// an analogy for the difference between a class and an object:
// a class would be the cookie cutter and a object would be the cookie

namespace TwentyOne
{
    class Program
    {
        private static char card;

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

            /*** REFERENCE AND DATA/STRUCTS TYPES***/
            //// every data type in c# is either reference type or a value type and each has different behaviors
            //// a class is like a blueprint and when a class is instantiated memory is allocated and configured according to that blue print
            //Card card1 = new Card();
            //// when card2 was assigned to card1, no new memoery was allocated
            //// instead card2 was given the address to card1's memory location and look here if the value is called
            //// or change the value at this address if you want to change the value
            //        /*** ALL CLASSES, created and pre-built, OPERATE THIS WAY IN C#, BY REFERENCE ***/
            //// any data type that stores values by reference are reference types
            //Card card2 = card1;
            //card1.Face = Face.Eight;
            //card2.Face = Face.King;
            //Console.WriteLine(card1.Face);
            // the trick above will not work with string datatype because strings are immutable

            // Changing Card from Class to Struct will output eight instead of king because structs can't be inherited


            /***
            // Value Type
            // a seperate independent instance 
            // integers, boolean, enums and DateTime are value types
            // if you go to the definition of integer you'll see that it is a struct
            int number = 5;
            // A STRUCT is the same as a class except that it is a VALUE TYPE and CAN'T BE inherited
            // Value types and Structs can't have a value of null; null is not a value
            ***/

            /*** Lamda functions 
            
            // lambda functionsexpose lists to functions
            Deck deck = new Deck();
            // what if we wanted to find a specific card, like how many aces are in the deck?
            // you can do it with a foreach loop
            int counter = 0;
            foreach (Card card in deck.Cards)
            {
                if (card.Face == Face.Ace)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            
            // OR it can be written with a lambda function

            // .Count is a lambda method/function
            // its counting all the elements, represented by x where x.face is equal to Ace
            Deck deck = new Deck();
            int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // creates a new List with just one line of code
            List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
            // adds 5 to each item on the list
            int sum = numberList.Sum(x => x + 5);
            // able to chain lambda functions
            
            // lambda functions are very hard to debug

            Console.WriteLine(sum);

            ***/

            //Deck deck = new Deck();

            //// call the method
            //deck = Shuffle(deck);
            ////you can add the named parameter to make it more readable
            //deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            //instead of writing the above write:
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);

            /*** FILE IO 
            
            //string text = "here is some text";
            //to write some text to a file
            // takes in an argument of the path of the file
            // if the log. txt doesn't exists then it will create it or overwrite it
            // @ tells the program to read everything as is
            //File.WriteAllText(@"C:\Users\Ricar\Desktop\twentyoneIO\log.txt", text);
            
            // reads the text file
            //string text = File.ReadAllText(@"C:\Users\Ricar\Desktop\twentyoneIO\log.txt");
            ***/

            /*** DATETIME 
            // Data Types DateTime and TimeSpan
            // Datetime is a value type
            // it is a struct so it not nullable
            DateTime datetime = new DateTime(1995, 5, 23, 8, 32, 45);

            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            // easy way to compare two dates and get the difference, result is in days
            TimeSpan ageAtGradiation = yearOfGraduation - yearOfBirth;
            ***/

            /*** Assembly and namespaces ***/
            // any code you write ends up getting compiled twice, either a .exe or a .dll, a .dll is a library file
            // the .exe or .dll is essecntially an assembly then compiled to machine code
            // an assembly is what you get after you compile the C# code

            // Namespaces is a way of organizing your code
            // using statements make it so we don't have to type out the entire path
            // allows you to use the same names for classes while having different namespaces

            // Constructor chaining
            // using the inheriting contructor
            //Player newPlayer = new Player("Ricky");

            // implicitly define the variable with var keyword
            //var newPlayer = new Player("Ricky");
            // the rule for using var is if the data type is obscurred in any way then use the data type otherwise you can use var

            //declaring a constant
            const string casinoName = "Grand Hotel and Casino";

            /*** GUID
            // global unique identifier (Guid)
            // the advantage of a guid is that it makes looking people a lot easier
            // extremely low odds of having the same Guid
            Guid identifier = Guid.NewGuid();
            ***/


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. WOuld you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // playerName and bank are the arguments passed into the constructor in class Player
                Player player = new Player(playerName, bank);
                // GUID
                player.Id = Guid.NewGuid();
                // logs the guid
                using (StreamWriter file = new StreamWriter(@"C:\Users\Ricar\Desktop\twentyoneIO\log.txt", true))
                {
                    // DateTime.Now gives the exact datetime object of this moment
                    file.WriteLine(player.Id);
                }
                // polymorphism
                Game game = new TwentyOneGame();
                // adding player to the game with overloaded operator
                game += player;
                // property of class Player
                player.isActivelyPlaying = true;
                // while the palyer is actively playing, and player has money, play the game
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playering!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
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