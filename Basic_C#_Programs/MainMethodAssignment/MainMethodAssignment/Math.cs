using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Math
    {
        static public int Subtractor(int x, int y)  //takes in 2 integers
        {
            return x - y;  //subtracts, and returns an integer
        }

        static public int Subtractor(double x, double y)  //takes 2 doubles
        {
            return Convert.ToInt32(x - y); //subtracts, returning integer rounded down
        }

        static public int Subtractor(string x, string y)
        {
            int a = Convert.ToInt32(x);  //converts string into integer if possible
            int b = Convert.ToInt32(y);
            return a - b;    //subtracts, and returns an integer

        }
    }
}
