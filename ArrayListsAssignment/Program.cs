using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // initializing a string array
        string[] stringArray = { "Hello", "How are you?", "Have you been alright?", "How are you feeling?", "Are you still the same?" };
        // asking the user to select a number
        Console.WriteLine("Please select a number between 0 - 4");
        // stores the response in the variable userInput
        int userInput = Convert.ToInt32(Console.ReadLine());
        
        // If else statement
        // if the user selects an appropriate number then the string at the selected index will be printed to the terminal
        if (userInput <= 4 && userInput >= 0)
        {
            Console.WriteLine(stringArray[userInput]);
        }
        
        else
        {
            // This string will be printed if the user selects a number outside the range of the array
            Console.WriteLine("I'm sorry that number was outside the range");
        }
        
        
        // Initializing integer array
        int[] integerArray = { 5, 6, 45, 63, 23 };
        // Asks for user input
        Console.WriteLine("Please select a number between 0 - 4");
        // stores input into a variable
        int userInput2 = Convert.ToInt32(Console.ReadLine());
        
        // if else statements
        if (userInput2 <= 4 && userInput2 >= 0)
        {
            // prints the value at the index of the array
            Console.WriteLine(integerArray[userInput2]);
        }
        else
        {
            // prints when the user input is outside the range of the array
            Console.WriteLine("That number was outside the range given");
        }


        //Initialize a list
        List<string> stringList = new List<string>();
        // range of itmes
        string[] names = { "Ricky", "Katie", "Larry", "Jordan", "Lisa", "Amber", "Josh"};
        // add range to list
        stringList.AddRange(names);
        Console.WriteLine("Select a number between 0 - 6 to pick a name");
        // stores user input into the variable
        int userInput3 = Convert.ToInt32(Console.ReadLine());
        
        // if else statments
        if (userInput3 <= 6 && userInput3 >= 0)
        {
            // prints the value of the list at the given index
            Console.WriteLine(stringList[userInput3]);
        }
        else
        {
            // prints when the user inputs a number outside of the range
            Console.WriteLine("please select a number within the given range");
        }
        
        Console.ReadLine();
    }
}
