using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person Sample = new Employee() { firstName = "Sample", lastName = "Student" };  //instantiation of Employee
            Sample.SayName();  //prints full name of employee Sample

            Console.ReadLine(); //pauses the program
        }
    }

}
