using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;  //instatiates current time
            Console.WriteLine(currentTime);  //prints it to console

            Console.WriteLine("Give me a number: ");       //instantiates hours added
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In {0} hours, it will be {1}",hours,currentTime.AddHours(hours)); //uses AddHours method, passing along the hours input from above
            Console.ReadLine();
        }
    }
}
