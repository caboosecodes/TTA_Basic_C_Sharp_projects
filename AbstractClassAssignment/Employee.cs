using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Employee class inheriting from abstract Person class
    class Employee : Person, IQuittable
    {
        // Properties
        public int Id { get; set; }
        
        /*** GENERIC ***/
        //public List<T> Things { get; set; }

        // SayName method from abstract class Person
        public override void SayName()
        {
            // able to add onto the method because SayName is a virtual Method
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            base.SayName();
        }

        // Quit method from interface
        public void Quit()
        {
            //
            Console.WriteLine("{0} {1} quits!", firstName, lastName);
        }

        //Overloading Operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // if statement checking to see if employee1 ID is equal to employee2 ID
            if (employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }

        // when overloading the "==" operator you must overload the "!=" operator as well
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (!employee1.Id.Equals(employee2.Id))
            {
                return true;
            }
            return false;
        }
    }
}
