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


            /*** Overloading "==" Operator Assignment ***/

            // instantiate 2 Employee objects
            Employee employee1 = new Employee() { Id = 1, firstName = "Bob", lastName = "Jones" };
            Employee employee2 = new Employee() { Id = 1, firstName = "Casey", lastName = "Jones" };

            // if statement using the overloaded operator
            if (employee1 == employee2)
            {
                // writes to the terminal if employee1 ID is == to employee2 ID
                Console.WriteLine("employee1 has the same Id as employee2");
            }
            else
            {
                // writes to the terminal if employee1 ID is != to employee2 ID
                Console.WriteLine("employee1 does not have the same Id as employee2");
            }


            Console.ReadLine();


        }
    }
}
