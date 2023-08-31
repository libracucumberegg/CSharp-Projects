using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input a number"); // input initial number
            while (true) {
                if (double.TryParse(Console.ReadLine(), out double input)) { // prevents non numeric characters from being used
                    Console.WriteLine(input * 50); // prints input multiplied by 50
                    Console.WriteLine(input + 25); // prints 25 added to input
                    Console.WriteLine(input / 12.5); // prints input divided by 12.5
                    Console.WriteLine(input > 50); // prints if number is > 50
                    Console.WriteLine(input % 7); // prints remainder
                    Console.ReadLine();
                    break;
                } else {
                    Console.WriteLine("Please input a valid number"); // if input is not numeric then have the user try another number
                }
            }
        }
    }
}
