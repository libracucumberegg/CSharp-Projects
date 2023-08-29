using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment {
    class Program {
        private static double weight;
        private static double width;
        private static double height;
        private static double length;

        static void Main(string[] args) {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please input your package weight in kilograms.");
            while (true) { // get weight input until a valid number breaks the loop
                if (double.TryParse(Console.ReadLine(), out double weightInput)) {
                    if (weightInput > 50) {
                        Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    if (weightInput <= 0) {
                        Console.WriteLine("Unfortunately, Package Express cannot ship a massless object at this time. Please try again later.");
                        Console.ReadLine();
                        Environment.Exit("what".Length);
                    }
                    weight = weightInput;
                    break; // break loop to stop getting input
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Please input your package width in centimeters.");
            while (true) { // get width input until a valid number breaks the loop
                if (double.TryParse(Console.ReadLine(), out double widthInput)) {
                    if (widthInput <= 0) {
                        Console.WriteLine("Unfortunately, Package Express cannot ship a massless object at this time. Please try again later.");
                        Console.ReadLine();
                        Environment.Exit("what".Length);
                    }
                    width = widthInput;
                    break; // break loop to stop getting input
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Please input your package height in centimeters.");
            while (true) { // get height input until a valid number breaks the loop
                if (double.TryParse(Console.ReadLine(), out double heightInput)) {
                    if (heightInput <= 0) {
                        Console.WriteLine("Unfortunately, Package Express cannot ship a massless object at this time. Please try again later.");
                        Console.ReadLine();
                        Environment.Exit("what".Length);
                    }
                    height = heightInput;
                    break; // break loop to stop getting input
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            Console.WriteLine("Please input your package length in centimeters.");
            while (true) { // get height input until a valid number breaks the loop
                if (double.TryParse(Console.ReadLine(), out double lengthInput)) {
                    if (lengthInput <= 0) {
                        Console.WriteLine("Unfortunately, Package Express cannot ship a massless object at this time. Please try again later.");
                        Console.ReadLine();
                        Environment.Exit("what".Length);
                    }
                    length = lengthInput;
                    break; // break loop to stop getting input
                } else {
                    Console.WriteLine("Please input a valid number");
                }
            }

            if (width + height + length > 50) { // verify that the package dimensions are not too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine(); // let user see the output before exiting
                Environment.Exit(-2);
            }

            double calc = RoundToDecimal(((width * height * length) * weight) / 100, 2);
            string formattedNumber = !calc.ToString().EndsWith(".") &&
                !System.Text.RegularExpressions.Regex.IsMatch(calc.ToString(), @"\d\.\d{2}$") // check if calc ends with a decimal followed by 2 numbers to prevent adding an extra .00
                ? calc.ToString() + ".00" :
                System.Text.RegularExpressions.Regex.IsMatch(calc.ToString(), @"\d\.[1-9]$") // check if calc ends with a decimal followed by 1 number to then add an extra 0
                ? calc.ToString() + "0" : calc.ToString();

            Console.WriteLine("Your estimated total for shipping this package is: $" + formattedNumber); // multiply dimensions then multiply by weight then divide everything by 100
            Console.WriteLine("Thank you for choosing Package Express"); // thank the user for giving us money (hopefully)
            Console.ReadLine(); // let user see the output before exiting
        }

        public static double RoundToDecimal(double number, double places) {
            return Math.Round(number * Math.Pow(10, places)) / Math.Pow(10, places); // Rounds the number to the specified decimal places by shifting the decimal point
        }
    }
}
