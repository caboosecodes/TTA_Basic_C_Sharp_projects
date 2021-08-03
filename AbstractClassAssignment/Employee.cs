using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Employee class inheriting from abstract Person class
    class Employee : Person
    {
        // SayName method from abstract class Person
        public override void SayName()
        {
            // able to add onto the method because SayName is a virtual Method
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            base.SayName();
        }
    }
}
