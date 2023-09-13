using System;
using System.Linq;
using System.Data.Entity;

namespace Final {
    class Program {
        static void Main(string[] args) {
            using (var db = new Context()) {
                Console.Write("Please enter the id of the new student: ");
                var sid = Console.ReadLine();

                Console.Write("Please enter the first name of the new student: ");
                var name = Console.ReadLine();

                Console.Write("Please enter the last name of the new student: ");
                var lname = Console.ReadLine();

                Console.Write("Please enter the date of birth of the new student: ");
                var dob = Console.ReadLine();

                var student = new Student(Int32.Parse(sid), name, lname, DateTime.Parse(dob));
                Console.WriteLine("Adding " + name + " to the database");
                db.Students.Add(student);
                db.SaveChanges();
                Console.WriteLine("Added and saved");

                // Display all Students from the database
                var query = from s in db.Students
                            orderby s.FirstName
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var item in query) {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }

                Console.ReadKey();
            }
        }
    }

    public class Student {
        private Student() { }

        public Student(int StudentId, string FirstName, string LastName, DateTime dob) {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.dob = dob;
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime dob { get; set; }
    }

    public class Context : DbContext {
        public DbSet<Student> Students { get; set; }
    }
}
