using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee() { FirstName = "Sample", LastName = "Student" };  //instantiating an Employee class object
            Sample.SayName();  //prints first+last name of Employee Sample

            Console.ReadLine(); //pauses program
        }
    }
}
