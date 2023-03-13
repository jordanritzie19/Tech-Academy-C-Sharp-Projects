using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());  //input 1
            Console.WriteLine("What do you want to subtract by? ");
            int int2 = Convert.ToInt32(Console.ReadLine());  //number to subtract by
            Console.WriteLine(int1 + " - " + int2 + " = " + Math.Subtractor(int1, int2)); //input1 - input2 = answer as integer

            Console.WriteLine("Input a decimal number: ");  
            double dub1 = Convert.ToDouble(Console.ReadLine());  //input 1 as double
            Console.WriteLine("What do you want to subtract by? ");
            double dub2 = Convert.ToDouble(Console.ReadLine());  //number to subtract by
            Console.WriteLine(dub1 + " - " + dub2 + " = " + Math.Subtractor(dub1, dub2));  //input1... answer as integer, though this uses the 'double' overloaded method

            Console.WriteLine("Input a number: ");
            string str1 = Console.ReadLine();  //input 1 as string, no convert needed as the input is already a string
            Console.WriteLine("Subtracted by? ");
            string str2 = Console.ReadLine();  //number to subtract by
            Console.WriteLine(str1 + " - " + str2 + " = " + Math.Subtractor(str1, str2));  //this uses the string overloaded method of same name Subtractor

            Console.ReadLine();  //pauses program
        }
    }
}
