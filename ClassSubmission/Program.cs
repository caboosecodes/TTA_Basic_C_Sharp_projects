using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Void Method
            // instantiates Class1 and assigns it to variable divide
            Class1 divide = new Class1();

            // asks the user for number
            Console.WriteLine("please input a whole number");
            // converts string to integer
            int num = Convert.ToInt32(Console.ReadLine());
            // returns the number divided by 2
            divide.Division(num);
            
            // Method Overloading and Static methods

            // asks user for input
            Console.WriteLine("What is your favorite animal?");
            // saves input to userAnimal Variable
            string userAnimal = Console.ReadLine();
            // passes userAnimal as a parameter to the Animal Method in the class named Static
            Console.WriteLine(Static.Animal(userAnimal));

            // asks the user for input
            Console.WriteLine("How many animals have you seen today?");
            // converts string into a integer
            int animalSeen = Convert.ToInt32(Console.ReadLine());
            // initializes class
            string variable = Static.Animal(animalSeen, out int twice);
            Console.WriteLine("{0} animals, wow!", animalSeen);
            // uses the out parameter
            Console.WriteLine("{0} is double the amount of animals you've seen", twice);

            Console.ReadLine();
        }
    }
}
