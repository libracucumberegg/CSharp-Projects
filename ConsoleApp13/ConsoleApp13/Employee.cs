using System;

namespace ConsoleApp13 {
    class Employee {
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Employee(int id, String FirstName, String LastName) {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
