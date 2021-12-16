using System;
using System.Data.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter a name (First Name) for the Student: ");
                var name = Console.ReadLine();

                var student = new Student { FirstName = name };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students orderby b.FirstName select b;

                Console.WriteLine("\n\nAll student in the database:");
                foreach (var element in query)
                {
                    Console.WriteLine("\nName: " + element.FirstName);
                }
                Console.ReadLine();
            }

        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Grade { get; set; }
        public int School { get; set; }
    }

    public class School
    {
        public int SchoolId { get; set; }
        public string NameSchool { get; set; }
        
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }

}
