using System;

namespace Operators_Assignment {
    class Employee {
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Employee(int id, String FirstName, String LastName) {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public static bool operator ==(Employee employee1, Employee employee2) { // overrides == when comparing 2 isntances of Employee
            return employee1.id == employee2.id;
        }

        public static bool operator !=(Employee employee1, Employee employee2) { // overrides != when comparing 2 isntances of Employee
            return employee1.id != employee2.id;
        }
    }
}
