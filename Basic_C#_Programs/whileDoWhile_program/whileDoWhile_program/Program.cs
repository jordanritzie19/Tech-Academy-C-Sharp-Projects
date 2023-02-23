using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDoWhile_program
{
    class Program
    {
        static void Main()
        {
            int counter = 1; //initializes count to 1
            while (counter < 4)  //loops until counter reaches 4
            {
                Console.WriteLine(counter); //prints current count
                counter++;  //and then increments
            }
            
            do  //runs a counting loop once and then...  (check while)
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter > 4 && counter < 7);  //keeps looping if between but not 4 and 7 
            Console.ReadLine();  //keeps console open
        }
    }
}
