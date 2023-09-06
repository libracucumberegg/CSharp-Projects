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

        public static bool operator ==(Employee employee1, Employee employee2) { // overrides == when comparing 2 instances of Employee to only compare id
            return employee1.id == employee2.id;
        }

        public static bool operator !=(Employee employee1, Employee employee2) { // overrides != when comparing 2 instances of Employee to only compare id
            return employee1.id != employee2.id;
        }

        public override bool Equals(object obj) { // overrides Equals to get Visual Studio to stop showing a warning
            return obj is Employee employee &&
                   id == employee.id;
        }

        public override int GetHashCode() { // overrides GetHashCode to get Visual Studio to stop showing a warning
            return 1877310944 + id.GetHashCode();
        }
    }
}
