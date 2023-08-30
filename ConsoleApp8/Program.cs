using System;

namespace ConsoleApp8 {
    class Program {
        private static int[] intArray = {857293, 625478, 932716, 291057, 509381, 748201, 162934, 385726, 912345, 678912};

        static void Main(string[] args) {
            Console.WriteLine("Choose a random number to divide every number in the array by");

            string input = Console.ReadLine();
            try {
                double divisor = double.Parse(input);

                for (int i = 0; i < intArray.Length; i++) {
                    Console.WriteLine(intArray[i] / divisor);
                }
            } catch (Exception e) {
                Console.WriteLine("Something went wrong when trying to divide the numbers by " + "\"" + input + "\"");
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Left try/catch");
            Console.ReadLine();
        }
    }
}
