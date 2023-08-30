using System;

namespace ConsoleApp9 {
    class Program {
        private static double numberInput;

        static void Main(string[] args) {
            Console.WriteLine("What number would you like to do the calculation on?");
            while (true) {
                if (double.TryParse(Console.ReadLine(), out double input)) {
                    if (input == 0) { // prevent very bad things
                        Console.WriteLine("Number cannot be 0");
                        continue;
                    }
                    numberInput = input; // sets number to be used later
                    Console.WriteLine("Number set to " + input);
                    break; // exit loop when number is set
                } else {
                    Console.WriteLine("Please try another number");
                }
            }

            MathUtils mathUtils = new MathUtils(); // initialize MathUtils in order to use it
            Console.WriteLine(numberInput + " + 925 = " + mathUtils.HandleAddition(numberInput));
            Console.WriteLine(numberInput + " % 7 = " + mathUtils.HandleModulo(numberInput));
            Console.WriteLine(numberInput + " / 3 = " + mathUtils.HandleDivision(numberInput));

            Console.ReadLine(); // lets user see output
        }
    }
}
