using System;

namespace Polymorphism_Assignment {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() { firstName = "James", lastName = "Adams" }; // makes new employee

            employee.SayName();
            employee.Quit();
            Console.ReadLine(); // lets user read output
        }
    }
}
