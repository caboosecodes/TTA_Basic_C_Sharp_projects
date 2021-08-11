using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new StudentContext())
            {
                // creating a new student
                Console.WriteLine("Enter Student's first name");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the Student's last name");
                var lastName = Console.ReadLine();
                Console.WriteLine("Enter the student's test scores (whole numbers please)");
                var testScores = Convert.ToInt32(Console.ReadLine());
                //save student to database
                var student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    TestScores = testScores
                };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine(student.FirstName + " " + student.LastName + " has been saved to the database");
                            
            }
            Console.ReadLine();
        }
    }
    //public class School
    //{
    //    public int SchoolId { get; set; }
    //    public string SchoolName { get; set; }

    //    public virtual List<Student> Students { get; set; }
    //}

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TestScores { get; set; }

        //public int SchoolId { get; set; }
        //public virtual School School { get; set; }

    }

    public class StudentContext : DbContext
    {
        //public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
