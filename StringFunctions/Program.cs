using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ricky";
            //// \"\" to put quotes around words
            //// \n to go to a new line
            //// \t to tab in on a line
            //// double back slash will print a single back slash \\ => \
            //// @ everything inside the quotation marks is a string and there is no escape sequences
            //string quote = "The man said, \\Hello, Ricky. \n Hello on a new line. \n \t Hello on a tab.";
            //string filename = @"C:\User\Ricky";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("y");

            //int length = name.Length;

            //name = name.ToLower();


            //Console.WriteLine(name);
            //Console.ReadLine();

            //// Strings are immutable, can't be changed
            //string name = "Ricky";
            //// just creates a new string in memory with the value of "joe"
            //name = "joe";

            //// dynamic object
            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Ricky");

            //Console.WriteLine();
            //Console.ReadLine();

            // String assignment 
            // string variables
            string WS1 = "Shall I compare thee to a summer's day? ";
            string WS2 = "Thou art more lovely and more temperate. ";
            string WS3 = "Rough Winds do shake the darling buds of May, ";
            string WS4 = "And summer's lease hath all too short a date. ";
            // concatenate the string variables together
            Console.WriteLine(WS1 + WS2 + WS3 + WS4);

            //creates a dictionary
            Dictionary<string, string> paragraph = new Dictionary<string, string>()
            {
                {"WS1", "Shall I compare thee to a summer's day? " },
                {"WS2", "Thou art more lovely and more temperate. " },
                {"WS3", "Rough Winds do shake the darling buds of May, " },
                {"WS4", "And summer's lease hath all too short a date. " },
            };
            // initializes stringbuilder
            StringBuilder sb = new StringBuilder();
            // foreach allows you to iterate through the dictionary
            // iterates through the values of the dictionary
            foreach(var val in paragraph.Values)
            {
                // appends the value to string builder
                sb.Append(val);
                // prints sb to the console
                Console.WriteLine(sb);
            }

            Console.ReadLine();
        }
    }
}
