using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission_Assignment
{
    class Divider
    {
        public void Divide(int x)  //this function doesn't return a value since it has void keyword
        {
            x = x / 2; //divides input by 2
            Console.WriteLine(x); //prints new value to console
        }

        public static int Divide(int x, out int y)  //static is unchanging, theres only one copy
        {
            y = x / 2;  //sets the new y value to be sent back out to main()
            return x / y;  //returns the numbers divided (always a 2)
        }

    }
}
