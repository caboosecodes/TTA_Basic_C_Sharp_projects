using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedConstructorAssignment
{
    public class Student
    {
        // Chained constructor
        public Student(string name) : this(name, Guid.NewGuid())
        {
        }
        // Constructor 
        public Student(string name, Guid Id)
        {
            Name = name;
            StudentId = Id;
        }
        // Class properties
        public string Name { get; set; }
        public Guid StudentId { get; set; }
    }
}
