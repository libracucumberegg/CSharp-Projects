using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() { firstName = "James", lastName = "Adams" }; // makes new employee

            employee.SayName();
            Console.ReadLine(); // lets user read output
        }
    }
}
