using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Adder
    {
        public static int AddTwo(int x, int y = 10)  //takes 2 numbers, y being optional. In the event y isn't specified, uses 10 as the value
        {
            return x + y; //returns numbers as integer
        }
    }
}
