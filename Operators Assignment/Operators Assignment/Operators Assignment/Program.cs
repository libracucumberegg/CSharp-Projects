using System;

namespace Operators_Assignment {
    class Program {
        static void Main() {
            Employee employee1 = new Employee(775930, "Stuart", "Sanchez");
            Employee employee2 = new Employee(774938, "Walter", "White");

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
