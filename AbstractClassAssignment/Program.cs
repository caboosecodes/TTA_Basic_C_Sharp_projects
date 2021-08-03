using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object initialization
            Employee worker = new Employee() { firstName = "Sample", lastName = "Student" };

            // calling on the inherited method
            worker.SayName();

            /*** Polymorphism Assignment ***/

            // declare Iquittable as a new Employee object
            IQuittable resign = new Employee() { firstName = "Billy", lastName = "Bob"};
           
            // Because resign is a IQuittable instance, other methods from class Employee are not available
            
            // calling the inherited method from the interface IQuittable
            resign.Quit();
            
            Console.ReadLine();
        }
    }
}
