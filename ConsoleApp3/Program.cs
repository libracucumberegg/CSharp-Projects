using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    class Program {
        private static int age;
        private static Boolean dui;
        private static int tickets;

        static void Main(string[] args) {
            Console.WriteLine("What is your age?");
            while (true) { 
                if (int.TryParse(Console.ReadLine(), out int ageInput)) {
                    age = ageInput;
                    break;
                } else {
                    Console.WriteLine("Please input a valid whole number");
                }
            }

            Console.WriteLine("Have you ever had a DUI?");
            while (true) {
                String input = Console.ReadLine();
                if (input.Equals("y") || input.Equals("yes") || input.Equals("true")) {
                    dui = true;
                    break;
                } else if (input.Equals("n") || input.Equals("no") || input.Equals("false")) {
                    dui = false;
                    break;
                } else {
                    Console.WriteLine("Please respond with yes/no");
                }
            }

            Console.WriteLine("How many speeding tickets do you have?");
            while (true) { 
                if (int.TryParse(Console.ReadLine(), out int ticketsInput)) {
                    tickets = ticketsInput;
                    break;
                } else {
                    Console.WriteLine("Please input a valid whole number");
                }
            }

            if (age >= 16 && !dui && tickets < 3) {
                Console.WriteLine("Congratulations! You are qualified for a license");
            } else {
                Console.WriteLine("Unfortunately, you are not qualified for a license due to 1 or more reasons including: ");
                if (age <= 15) {
                    Console.WriteLine("You are younger than 16.");
                }

                if (dui) {
                    Console.WriteLine("You have had a DUI before.");
                }

                if (tickets >= 3) {
                    Console.WriteLine("You have " + tickets + " active tickets. (Maximum 3)");
                }

                if (age <= 15 && (dui || tickets >= 3)) {
                    Console.WriteLine("I don't know how you managed to break the law without being caught without a valid license but you managed it.");
                }
            }

            Console.ReadLine();
        }
    }
}
