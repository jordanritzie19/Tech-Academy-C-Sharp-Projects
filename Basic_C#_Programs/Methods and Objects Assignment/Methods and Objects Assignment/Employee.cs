using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person  //employee class has parent class Person
    {
        public int Id { get; set; }  //id property, just for employee, not 'Person' as well

    }
}
