using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Abstract class; it cannot be instantiated
    public abstract class Person
    {
        // Class Properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Virtual Method; it can be overwritten or added onto
        public virtual void SayName()
        {

        }

    }
}
