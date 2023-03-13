using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");     
            int int1 = Convert.ToInt32(Console.ReadLine());   //first number, HAS to give a number
            Console.WriteLine("Give me another number, or just leave it blank if you'd like");
            string intHolder = Console.ReadLine();  //holds value as string to check for integer or not
            if (intHolder.Trim() == "")  //removes whitespace in the event user presses a space before entering
            {
                Console.WriteLine(int1 + " + 10 = " + Adder.AddTwo(int1));  //no 2nd number, itll just add 10
            }
            else  //case where 2 numbers were given
            {
                int int2 = Convert.ToInt32(intHolder);
                Console.WriteLine(int1 + " + " + int2 + " = " + Adder.AddTwo(int1, int2)); //adds both numbers together
            }
            Console.ReadLine(); //pauses program
        }
    }
}
