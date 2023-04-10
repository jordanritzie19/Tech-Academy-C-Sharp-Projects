using System;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter the students First Name");
                string fname = Console.ReadLine();
                Console.WriteLine("Enter the students Last Name");
                string lname = Console.ReadLine();
                Console.WriteLine("Enter their year (i.e second year)");
                string year = Console.ReadLine();
                Console.WriteLine("Enter their current GPA to one decimal place");
                double gpa = Convert.ToDouble(Console.ReadLine());

                var student = new Student { FirstName = fname, LastName = lname, GPA = gpa, Year = year };
                db.Students.Add(student);
                db.SaveChanges();

                //displays all students in db
                var query = from s in db.Students
                            orderby s.GPA descending
                            select s;

                Console.WriteLine("Students in order by GPA: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName);
                }

                Console.ReadLine();  //pauses the program
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public string Year { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set;}
    }
}
