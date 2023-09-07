using System;
using System.Collections.Generic;

namespace ConsoleApp13 {
    class Program {
        static List<Employee> employees = new List<Employee>();
        static List<Employee> joe = new List<Employee>();
        static List<Employee> lowIDs = new List<Employee>();

        static void Main(string[] args) {
            Employee employee1 = new Employee(154, "Alice", "Smith");
            Employee employee2 = new Employee(574, "Bob", "Johnson");
            Employee employee3 = new Employee(352, "Charlie", "Brown");
            Employee employee4 = new Employee(004, "David", "Davis");
            Employee employee5 = new Employee(057, "Eve", "Wilson");
            Employee employee6 = new Employee(214, "Joe", "Stevens");
            Employee employee7 = new Employee(657, "Grace", "Anderson");
            Employee employee8 = new Employee(377, "Henry", "Thomas");
            Employee employee9 = new Employee(005, "Joe", "Martinez");
            Employee employee10 = new Employee(716, "Jack", "Lee");
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            for (int i = 0; i < employees.Count; i++) { // checks for employees with the first name Joe using a for loop
                Employee em = employees[i];

                if (em.FirstName.Equals("Joe")) {
                    joe.Add(em);
                }
            }
            joe.Clear();

            employees.ForEach(e => { // checks for employees with the first name Joe using a foreach inside a lambda
                if (e.FirstName.Equals("Joe")) {
                    joe.Add(e);
                }
            });

            employees.ForEach(e1 => { // checks for employees with the an id more than 5 using a foreach inside a lambda
                if (e1.id > 5) {
                    lowIDs.Add(e1);
                }
            });
        }
    }
}
