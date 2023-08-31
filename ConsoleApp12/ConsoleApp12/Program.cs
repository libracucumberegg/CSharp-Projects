using System;

namespace ConsoleApp12 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() { firstName = "James", lastName = "Adams" }; // makes new employee

            employee.SayName();
            Console.ReadLine(); // lets user read output
        }
    }

    public abstract class Person {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }

    public class Employee : Person { // inherit person class
        public int id { get; set; }

        public override void SayName() { // override abstract method
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
