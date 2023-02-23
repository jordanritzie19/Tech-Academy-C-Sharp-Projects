using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main()
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\" Jesse. \nHello on a new line \n\tHello on a tab.";
            //string fileName = @"C:\\Users\\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;
            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            string name = "Jesse"; //strings are immutable
            name = "Joe";  //this actually just creates a new string

            name = name.ToUpper();

            string cat1 = "co";
            string cat2 = "nc";
            string cat3 = "at";
            Console.WriteLine("You can concat like this " + cat1 + cat2 + cat3 + " hehe");

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse ");
            sb.Append("and this is my story ");
            sb.Append("I teach you code... ");
            sb.Append("through the Tech Academy. ");

            Console.WriteLine("\t"+sb);
            Console.ReadLine();
        }
    }
}
