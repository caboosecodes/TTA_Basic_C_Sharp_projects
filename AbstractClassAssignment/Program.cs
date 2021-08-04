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
            //// Object initialization
            //Employee worker = new Employee() { firstName = "Sample", lastName = "Student" };

            //// calling on the inherited method
            //worker.SayName();


            ///*** Polymorphism Assignment ***/

            //// declare Iquittable as a new Employee object
            //IQuittable resign = new Employee() { firstName = "Billy", lastName = "Bob" };

            //// Because resign is a IQuittable instance, other methods from class Employee are not available

            //// calling the inherited method from the interface IQuittable
            //resign.Quit();


            ///*** Overloading "==" Operator Assignment ***/

            //// instantiate 2 Employee objects
            //Employee employee1 = new Employee() { Id = 1, firstName = "Bob", lastName = "Jones" };
            //Employee employee2 = new Employee() { Id = 2, firstName = "Casey", lastName = "Jones" };

            //// if statement using the overloaded operator
            //if (employee1 == employee2)
            //{
            //    // writes to the terminal if employee1 ID is == to employee2 ID
            //    Console.WriteLine("employee1 has the same Id as employee2");
            //}
            //else
            //{
            //    // writes to the terminal if employee1 ID is != to employee2 ID
            //    Console.WriteLine("employee1 does not have the same Id as employee2");
            //}

            /*** LAMBDA ASSIGNMENT ***/

            // Instantiate 10 Employee objects
            Employee employee1 = new Employee() { Id = 1, firstName = "Joe", lastName = "Doe" };
            Employee employee2 = new Employee() { Id = 2, firstName = "Bob", lastName = "Jones" };
            Employee employee3 = new Employee() { Id = 3, firstName = "Jack", lastName = "Tracy" };
            Employee employee4 = new Employee() { Id = 4, firstName = "Kate", lastName = "Baxter" };
            Employee employee5 = new Employee() { Id = 5, firstName = "Joe", lastName = "Shoemaker" };
            Employee employee6 = new Employee() { Id = 6, firstName = "Jill", lastName = "Smith" };
            Employee employee7 = new Employee() { Id = 7, firstName = "Amber", lastName = "Black" };
            Employee employee8 = new Employee() { Id = 8, firstName = "Vanessa", lastName = "Moriarty" };
            Employee employee9 = new Employee() { Id = 9, firstName = "Alice", lastName = "Goo" };
            Employee employee10 = new Employee() { Id = 10, firstName = "Billy", lastName = "Dern" };
            
            // Instantiate a new List and add the 10 Employee objects to the list
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            // Instantiate a new list
            List<Employee> newList = new List<Employee>();

            // for every employee in the List employees
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    // add the employee to the new list if their name is "Joe"
                    newList.Add(employee);
                }
            }
            /*** Code used to check the newList

            foreach (Employee x in newList)
            {
                Console.WriteLine(x.firstName);
            }
            ***/

            // Instantiate another List called lambdaList
            List<Employee> lambdaList = new List<Employee>();
            // lambda expression of foreach
            employees.ForEach(delegate (Employee x)
            {
                if (x.firstName == "Joe")
                {
                    // add employee to lambdaList is their first name is "Joe"
                    lambdaList.Add(x);
                }
            });

            /*** Code used to check the newList
            
            foreach (Employee x in lambdaList)
            {
                Console.WriteLine(x.firstName);
            }

            ***/

            // instantiate another list
            List<Employee> idList = new List<Employee>();
            // same as code above but only adding employees whose id is greater than 5
            employees.ForEach(delegate (Employee y)
            {
                if (y.Id > 5)
                {
                    idList.Add(y);
                }
            });

            /*** Code used to check the newList
            
            foreach (Employee y in idList)
            {
                Console.WriteLine(y.Id);
            }

            ***/

            Console.ReadLine();

            
            
            ///*** Generic parameters and generic properties ***/

            //Employee<string> someThing = new Employee<string>();
            //someThing.Things = new List<string>();
            //string[] input = { "one", "two", "three" };
            //someThing.Things.AddRange(input);

            //foreach (string thing in someThing.Things)
            //{
            //    Console.WriteLine(thing);
            //}

            //Employee<int> anotherThing = new Employee<int>();
            //anotherThing.Things = new List<int>();
            //int[] input2 = { 1, 2, 3 };
            //anotherThing.Things.AddRange(input2);

            //foreach (int thing in anotherThing.Things)
            //{
            //    Console.WriteLine(thing);
            //}
        }
    }
}
