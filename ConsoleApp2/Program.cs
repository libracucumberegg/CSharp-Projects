using System;

namespace ConsoleApp2 {
    class Program {
        private static Person person1 = new Person(0, 0);
        private static Person person2 = new Person(0, 0);

        static void Main(string[] args) {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Input hourly rate");
            while (true) {
                if (double.TryParse(Console.ReadLine(), out double input)) {
                    person1.setHourlyRate(input);
                    break;
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Input hours worked/week");
            while (true) {
                if (int.TryParse(Console.ReadLine(), out int input1)) {
                    person1.setHoursWorked(input1);
                    break;
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Person 2");
            Console.WriteLine("Input hourly rate");
            while (true) {
                if (double.TryParse(Console.ReadLine(), out double input2)) {
                    person2.setHourlyRate(input2);
                    break;
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Input hours worked/week");
            while (true) {
                if (int.TryParse(Console.ReadLine(), out int input3)) {
                    person2.setHoursWorked(input3);
                    break;
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            double person1Salary = (person1.getHourlyRate() * person1.getHoursWorked()) * 52;
            double person2Salary = (person2.getHourlyRate() * person2.getHoursWorked()) * 52;
            Console.WriteLine("Annual salary of Person 1: $" + person1Salary);
            Console.WriteLine("Annual salary of Person 2: $" + person2Salary);

            Console.WriteLine("Person 1 makes more money than Person 2? " + (person1Salary > person2Salary));
            Console.ReadLine();
        }
    }

    class Person {
        double hourlyRate;
        int hoursWorked;

        public Person(double hourlyRate, int hoursWorked) {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public double getHourlyRate() {
            return hourlyRate;
        }

        public void setHourlyRate(double hourlyRate) {
            this.hourlyRate = hourlyRate;
        }

        public double getHoursWorked() {
            return hourlyRate;
        }

        public void setHoursWorked(int hoursWorked) {
            this.hoursWorked = hoursWorked;
        }
    }
}
