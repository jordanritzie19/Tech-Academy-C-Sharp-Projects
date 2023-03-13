using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Class1
    {
        public void holdTwo(int x, int y)  //void means a value isn't returned
        {
            x += 4;  //adds 4 to x, though this is never used :(
            Console.WriteLine(y);  //prints out argument y
        }
    }
}
