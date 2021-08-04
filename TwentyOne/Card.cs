using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    // change Card to struct
    public struct Card
    {
        // what properties does a playing card have?
        // set oboject properties; they don't do anything; that's what METHODS are for
          
        
        // a constructor: values assigned to an object upon creation
        // the contruction method name is ALWAYS the name of the class
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        
        // data type "string"
        // Suit is the name of the property
        // you can get or set this property
        // making the property public makes accessible to other parts of the program
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    // Enum
    // inside an enum the underlying value starts in order and start with zero
    // you can set the values
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    
}
