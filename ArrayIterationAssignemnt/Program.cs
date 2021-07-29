// Six part assignment

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIterationAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One: Append user input to string element in array
            Console.WriteLine("Part One\n");
            // initializes an array "randomColors"
            string[] randomColors = { "Blue ", "Black ", "White ", "Red ", "Green ", "Yellow ", "Purple " };

            // Asks for user input and saves it to a variable
            Console.WriteLine("Please enter in a color");
            string userColor = Console.ReadLine();
            // for loop to iterate through the array

            // for loop
            for (int i = 0; i < randomColors.Length; i++)
            {
                // appends the userColor to the string at the index i in the array randomColors
                randomColors[i] = randomColors[i] + userColor;
                // Prints the string at the index i in the array randomColors
                Console.WriteLine(randomColors[i]);
            }


            // Part Two: Infinite Loop
            Console.WriteLine("Part Two\n");

            // x variable stores data type integer
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine("Without incrementing x this will print indefinitely");
                // Need to add the increment to prevent infinite loop
                // to x++ where the value will be used then incremented as opposed ++x will increment then use the value
                x++;
            }


            // Part Three: Iterating using "<" and "<=" operator 
            Console.WriteLine("Part Three\n");

            // intializing integer variables
            int a = 0;
            int b = 0;

            // while loop using < operator
            while (a < 5)
            {
                //prints the value of a to the terminal
                Console.WriteLine(a);
                //increments a by 1
                a++;
            }
            // while loop using <= operator
            while (b <= 5)
            {
                // prints the value of b to the terminal
                Console.WriteLine(b);
                // increments b by 1
                b++;
            }

            // Part Four: displaying the index
            Console.WriteLine("Part Four\n");

            // initialize a list
            List<string> pets = new List<string>();
            // populate list with strings
            pets.Add("dog");
            pets.Add("cat");
            pets.Add("bird");
            pets.Add("snake");
            pets.Add("fish");
            pets.Add("turtle");
            pets.Add("snake");

            // asks user to input a pet
            Console.WriteLine("Please guess a pet, for example: dog");
            string userPet = Console.ReadLine();
            // checks to see if userPet in the list pets; Contains() returns a true or false
            bool isPetPresent = pets.Contains(userPet);


            if (isPetPresent == true)
            {
                // if the user's pet is present in the list then find the index
                int index = pets.FindIndex(z => z.Contains(userPet));
                // prints response containing the user's guess and index of that guess
                Console.WriteLine("Your guess of " + userPet + " was on the list at the index of: " + index);
            }
            else
            {
                // prints if the pet was not on the list
                Console.WriteLine("Sorry that pet was not on the list");
            }


            // Part Five: repeat strings in lists
            Console.WriteLine("Part Five\n");

            // initialize a List of strings
            List<string> farmAnimals = new List<string>();
            farmAnimals.Add("cow");
            farmAnimals.Add("chicken");
            farmAnimals.Add("goat");
            farmAnimals.Add("pig");
            farmAnimals.Add("chicken");
            farmAnimals.Add("sheep");
            farmAnimals.Add("turkey");
            farmAnimals.Add("pig");

            // asks for user input
            Console.WriteLine("please guess a farm animal, for example: goat");
            string userAnimal = Console.ReadLine();
            //bool isAnimalPresent = farmAnimals.Contains(userAnimal);

            for (int i = 0; i < farmAnimals.Count; i++)
            {
                if (farmAnimals[i] == userAnimal)
                {
                    //int animalIndex = farmAnimals.FindIndex(w => w.Contains(userAnimal));
                    Console.WriteLine("your guess of " + userAnimal + " is at the index of: " + i);
                }
                else
                {
                    Console.WriteLine("your animal is not on the list");

                }
            }


            // Part Six: 

            Console.WriteLine("Part Six\n");
            // initialize a list of strings
            List<string> names = new List<string>();
            // populate the list
            names.Add("sally");
            names.Add("tom");
            names.Add("mark");
            names.Add("sally");
            names.Add("alice");
            names.Add("bob");

            // initialize a second empty list
            List<string> duplicate = new List<string>();

            // for every element in the list names
            foreach (string name in names)
            {
                // if the duplicate List does not contain the variable name
                if (!duplicate.Contains(name))
                {
                    // adds the name to duplicate List
                    duplicate.Add(name);
                    // prints to the console
                    Console.WriteLine(name + " was not previously in the list");
                }
                // if the name is already in the duplicate List
                else if (duplicate.Contains(name))
                {
                    // prints to the console
                    Console.WriteLine(name + " was on the list");
                }
            }

            Console.ReadLine();

        }
    }
}
