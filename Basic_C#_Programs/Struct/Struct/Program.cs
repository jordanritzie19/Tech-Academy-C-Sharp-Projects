using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number value = new Number();  //instantiate struct
            value.Amount = 4;

            Console.WriteLine(value.Amount);  //prints value
            Console.ReadLine(); //pauses program
        }
    }
}
