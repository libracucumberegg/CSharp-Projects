using System;

namespace ConsoleApp6 {
    class Program {
        private static string[] stringArray = {"there", "are", "very", "few", "instances", "of", "where", "frogs", "will", "eat", "a", "human"}; // initialize string array
        private static int[] intArray = {4, 9, 56, 1, 74, 93, 24, 288, 68, 55, 111, 177, 957, 24, 36, 18}; // initialize int array

        static void Main(string[] args) {
            Console.WriteLine("Choose a number to index a string array");
            while (true) {
                if (int.TryParse(Console.ReadLine(), out int i)) {
                    try {
                        Console.WriteLine("Index " + i + " is: " + stringArray[i]);
                        break;
                    } catch (Exception) {
                        Console.WriteLine("That index in the array does not exist");
                    }
                } else {
                    Console.WriteLine("Please choose a whole number");
                }
            }

            Console.WriteLine("Choose a number to index an int array");
            while (true) {
                if (int.TryParse(Console.ReadLine(), out int i)) { // ensures index is actually an integer
                    try {
                        Console.WriteLine("Index " + i + " is: " + intArray[i]);
                        break;
                    } catch (Exception) { // if exception is caught then the index doesn't exist
                        Console.WriteLine("That index in the array does not exist");
                    }
                } else {
                    Console.WriteLine("Please choose a whole number");
                }
            }

            Console.WriteLine("end of index searching");
            Console.ReadLine(); // lets user see the output
        }
    }
}
