using System;

namespace Method_Class_Assignment {
    class Program {
        static Random random = new Random();

        static void Main(string[] args) {
            Math.HandleMath(random.Next(0, 100), random.Next(0, 100)); // call method with random numbers
            Math.HandleMath(int1: random.Next(0, 100), int2: random.Next(0, 100)); // call method with param names
            Console.ReadLine(); // lets user see output
        }
    }

    class Math { 
        public static void HandleMath(int int1, int int2) {
            int int1Math = int1 % 2; // calculates remainder
            Console.WriteLine(int2);
        }
    }
}
