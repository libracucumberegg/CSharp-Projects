using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 {
    class Program {
        private static int number = 0;

        static void Main(string[] args) {
            while (number++ <= 10) { // adds 1 to number and prints to console if the number is less than or equal to 10
                Console.WriteLine("Number is still less than or equal to 10");
            }

            do { // adds 1 to number and prints to console what the number currently is until it reaches 20
                number++;
                Console.WriteLine("The number is currently equal to " + number);
            } while (number != 20);

            Console.ReadLine();
        }
    }
}
