using System;

namespace Polymorphism_Assignment {
    public class Employee : Person, IQuittable { // inherit person class and IQuittable interface
        public int id { get; set; }

        public override void SayName() { // override Person SayName
            Console.WriteLine("Name: " + firstName + lastName);
        }

        public void Quit() {
            Console.WriteLine("I quit!"); // overrides IQuittable Quit
        }
    }
}
