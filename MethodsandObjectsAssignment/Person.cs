using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandObjectsAssignment
{
    // Person Class
    public class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // void Method with no parameters
        public void SayName()
        {
            // outputs to the terminal
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }

    
}
