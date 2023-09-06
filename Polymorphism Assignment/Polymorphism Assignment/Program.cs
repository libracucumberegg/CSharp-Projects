using System;

namespace Polymorphism_Assignment {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() { firstName = "James", lastName = "Adams" }; // makes new employee

            employee.SayName();

            IQuittable quittable = employee; // makes IQuittable object using employee since it inherits IQuittable
            quittable.Quit();
            Console.ReadLine(); // lets user read output
        }
    }
}