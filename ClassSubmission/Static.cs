using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Static
    {
        // Method overloading

        // static m
        public static string Animal(string userAnimal)
        {
            // concatenates userAnimal with a string and saves it repsonse
            string response = userAnimal + " is a fantastic animal!";
            return response;
        }

        public static string Animal(int animalSeen, out int twice)
        {
            // multiplies animalSeen by 2
            twice = animalSeen * 2;
            // concatenates the integer animalSeen with a string
            string response = animalSeen + " animals, wow! ";
            return response;
        }
    }
}
