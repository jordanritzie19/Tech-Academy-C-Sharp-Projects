using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider dividend = new Divider();  //instantiates the divider 'dividend'
            Console.WriteLine("Give me a number: ");
            dividend.Divide(Convert.ToInt32(Console.ReadLine()));  //sends in inputted number as argument in class method. This pastes new number

            int x = 26, y = 52;  //some values to use later
            Console.WriteLine("Currently y = 52");  //this is used as proof of output parameter
            int j = Divider.Divide(x, out y);  //y's value gets changed in method to be half of value of x
            Console.WriteLine("But now its half " + x + " aka " + y);  //proof of y changing
            Console.WriteLine(j);  //the int value returned from Divider.Divide method above. Should always be '2'
            Console.ReadLine();  //pauses program
        }
    }
}
