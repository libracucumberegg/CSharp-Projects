using System;

namespace ConsoleApp11 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() { firstName = "James", lastName = "Adams" }; // makes new employee
            
            employee.SayName();
            Console.ReadLine(); // lets user read output
        }
    }

    public class Person { 
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName() {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }

    public class Employee : Person { // inherit person class
        public int id { get; set; }
    }
}
