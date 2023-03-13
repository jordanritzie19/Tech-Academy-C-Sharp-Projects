using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Person
    {
        public string FirstName { get; set; }  //property first name
        public string LastName { get; set; }   //last name

        public void SayName()   //simply prints out first+last
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }


    }
}
