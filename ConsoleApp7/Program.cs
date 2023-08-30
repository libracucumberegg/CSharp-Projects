using System;

namespace ConsoleApp7 {
    class Program {
        private static string string1 = "Beware; ";
        private static string string2 = "for I am the fearless, ";
        private static string string3 = "and therefore powerful.";
        private static string[] stringArray = {"chair", "lamp", "table", "book", "clock", "mirror", "pillow", "vase", "computer", "door"};
        private static string[] stringArray2 = new string[6];
        private static Boolean foundWord = false;
        private static string[] letters = {
            "d", "b", "t", "z", "x", "j", "r", "k", "i", "y",
            "c", "m", "s", "w", "h", "u", "l", "a", "e", "v",
            "o", "f", "n", "q", "g", "p", "a", "y", "z", "b"};

        static void Main(string[] args) {
            Console.WriteLine(string1 + string2 + string3);

            string x = "who controls the past controls the future";

            Console.WriteLine(x.ToUpper());

            Console.WriteLine("Please input some random text");
            while (true) {
                string word = Console.ReadLine(); // store word to prevent having to spam press enter
                if (word.Equals("")) { // prevent no text being added
                    Console.WriteLine("Please input text");
                } else {
                    for (int i = 0; i < stringArray.Length; i++) {
                        stringArray[i] = stringArray[i] + " " + word; // add word to already existing word
                    }
                    break;
                }
            }

            for (int i = 0; i < stringArray.Length; i++) {
                Console.WriteLine(stringArray[i]); // prints word at specified index with the users inputted word
            }

            for (int i = 0; i <= 5; i++) {
                stringArray2[i] = GetWord(i); // gets word based on index number
            }

            Console.WriteLine("Input some text to search the array for");
            while (!foundWord) {
                string word = Console.ReadLine();
                for (int i = 0; i < stringArray2.Length; i++) { 
                    if (stringArray2[i].Equals(word)) { // index array at wherever the for loop is at then compares to the word the user picked
                        Console.WriteLine(word + " found at index " + i);
                        foundWord = true; // stops while loop from running
                        break; // breaks out of for loop to prevent unnecessary indexing
                    }
                    if (i == stringArray2.Length - 1) { // indexing starts at 0 whereas length starts at 1
                        Console.WriteLine(word + " was not found in the array");
                    }
                }
            }

            for (int i = 0; i < letters.Length; i++) { // start first for loop to get inital letters
                for (int j = i + 1; j < letters.Length; j++) { // start a second for loop to compare the array with itself and adding +1 to stop printing duplicate index numbers
                    if (letters[i].Equals(letters[j])) { // i != j to prevent checking for letters that are in the same spot
                        Console.WriteLine("Found duplicate letter " + letters[i] + " at index " + i + " and " + j);
                    }
                }
            }

            Console.ReadLine();
        }

        public static String GetWord(int i) { 
            switch (i) { // switch to check where the array index is at
                case 0: {
                        return "service";
                }
                case 1: {
                        return "tortilla";
                }
                case 2: {
                        return "community";
                }
                case 3: {
                        return "spice";
                }
                case 4: {
                        return "node";
                }
                case 5: {
                        return "caffeine";
                }
                default: {
                        return "this shouldn't happen"; // tell visual studio to go away
                }
            }
        }
    }
}
