using System;

namespace ConsoleApp14 {
    class Program {
        static void Main(string[] args) {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToString());

            Console.WriteLine("Please input an integer to add hours to the current time");

            while (true) {
                String read = Console.ReadLine();
                if (Int32.TryParse(read, out int time)) {
                    Console.WriteLine(dateTime.AddHours(time));
                    break;
                } else {
                    Console.WriteLine("Please input a valid integer");
                }
            }

            Console.ReadLine();
        }
    }
}
