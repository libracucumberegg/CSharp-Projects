using System;

namespace ConsoleApp10 {
    class Program {
        private static int inputNumber;
        private static double inputNumberD;
        static Random random = new Random();
        static string[] operators = { "+", "-", "*", "/", "%" };

        static void Main(string[] args) {
            Console.WriteLine("Please input an integer");

            while (true) {
                string inputStr = Console.ReadLine();
                if (int.TryParse(inputStr, out int input)) { // verify input is an integer
                    inputNumber = input;
                    break;
                } else {
                    Console.WriteLine("Please input a whole number");
                }
            }

            Console.WriteLine("Random calculation with " + inputNumber + " returned " + RandomOperatorMath(inputNumber));

            Console.WriteLine("Please input a double");

            while (true) {
                string inputStr = Console.ReadLine();
                if (double.TryParse(inputStr, out double input)) { // verify input is a double
                    inputNumberD = input;
                    break;
                } else {
                    Console.WriteLine("Please input a whole number");
                }
            }

            Console.WriteLine("Random calculation with " + inputNumberD + " returned " + RandomOperatorMath(inputNumberD));

            Console.ReadLine(); // let user see output

        }

        public static double RandomOperatorMath(double operand1) {
            string randomOperator = operators[random.Next(operators.Length)]; // gets random operator from array
            double operand2 = random.Next(1, 20); // gets random number for second operand
            double result = 0;

            switch (randomOperator) { // do math based on operand
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                case "%":
                    return operand1 % operand2;
            }

            return result;
        }

        public static int RandomOperatorMath(int operand1) {
            string randomOperator = operators[random.Next(operators.Length)]; // gets random operator from array
            int operand2 = random.Next(1, 20); // gets random number for second operand
            int result = 0;

            switch (randomOperator) { // do math based on operand
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                case "%":
                    return operand1 % operand2;
            }

            return result;
        }
    }
}
