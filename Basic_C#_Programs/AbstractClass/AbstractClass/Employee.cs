using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person  //:Person means its inheriting from person class
    {
        public override void SayName()  //fulfills SayName() function requirement
        {
            Console.WriteLine("Employee " + firstName + lastName);
        }
    }
}
