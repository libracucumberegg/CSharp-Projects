using System;

namespace Parsing_Enums_Assignment {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please pick a day of the week");
            Days day; // will be used for later for console output

            while (true) {
                string line = Console.ReadLine().ToUpper(); // enums are all uppercase and cannot be parsed unless the string is uppercase
                if (Enum.TryParse<Days>(line, out Days dayInput)) {
                    day = dayInput;
                    break; // break out of the loop since a valid day was found
                } else {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }

            Console.WriteLine("You have picked " + day); // tell the user the date they chose and to verify 
            Console.ReadLine();
        }
    }

    public enum Days { 
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    }
}
