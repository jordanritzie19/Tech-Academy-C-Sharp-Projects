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
            Employee Sample = new Employee() { firstName = "Sample", lastName = "Student" };  //instantiation of Employee
            Console.WriteLine("Employee " + Sample.firstName + " " + Sample.lastName + " is working.");
            //Sample.SayName();  //prints full name of employee Sample
            Console.WriteLine(Sample.IsWorking);

            Console.WriteLine(Sample.firstName + " has found better opportunities and has left the company");
            Console.WriteLine(Sample.firstName + " " + Sample.lastName + " works here.");
            Sample.Quit();
            Console.WriteLine(Sample.IsWorking);

            IQuittable quitter = new Employee();  //polymorphism
            quitter.Quit();
            Console.ReadLine(); //pauses the program

            
        }
    }

}
