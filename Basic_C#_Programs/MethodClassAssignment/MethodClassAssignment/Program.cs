using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 instance = new Class1(); //instantiatiation of 'Class1' class
            instance.holdTwo(2, 4); //x =2, y=4. This should print '4'
            instance.holdTwo(y: 4, x: 6); //named parameters can be out of order, this should print '4'
            Console.ReadLine(); //pauses program
        }

    }
}
