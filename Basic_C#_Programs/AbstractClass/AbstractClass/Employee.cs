using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable  //:Person means its inheriting from person class, using IQuittable interface
    {
        
        public override void SayName()  //fulfills SayName() function requirement
        {
            Console.WriteLine("Employee " + firstName + lastName);
        }

        public void Quit()  //required by IQuittable interface
        {
            IsWorking = false; //sets working state to false, as they have Quit
        }
        public bool IsWorking { get; set; } = true; //initial value of isWorking is true
    }
}
