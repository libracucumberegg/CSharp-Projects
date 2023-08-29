using System;
using System.Text;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {
            string string1 = "this is";
            string string2 = "a concated";
            string string3 = "string";

            string concated = string1 + " " + string2 + " " + string3;

            Console.WriteLine(concated);
            Console.WriteLine((concated + " but uppercase").ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            sb.Append(" Sed nec lectus vitae justo consectetur tristique.");
            sb.Append(" Fusce dapibus, mauris a luctus eleifend, nisl diam fringilla diam, in porta ligula nisi in ante.");
            sb.Append(" Sed euismod, mi et feugiat ullamcorper, sem turpis tincidunt sem, vel vulputate ligula mi a nunc.");
            sb.Append(" Integer id leo sed urna elementum pretium.");
            sb.Append(" Sed auctor, nunc non porttitor fringilla, elit metus iaculis velit, et rutrum nunc elit a tortor.");
            sb.Append(" Phasellus ullamcorper turpis et tortor ullamcorper, in pretium lacus consequat.");
            sb.Append(" Cras venenatis, mauris vel iaculis mattis, nunc justo efficitur dui, id consequat neque erat id lectus.");
            sb.Append(" Sed ac quam elit.");
            sb.Append(" Quisque sodales dui non nunc dignissim, nec rhoncus nulla tristique.");
            sb.Append(" Aenean et nunc ex.");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
