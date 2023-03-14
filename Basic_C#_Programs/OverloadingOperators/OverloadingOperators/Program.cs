using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jack = new Employee() { FirstName = "Jack", LastName = "Miller", Id = 1000 };    //instiatiating some Employees
            Employee Jack2 = new Employee() { FirstName = "Jack", LastName = "Larange", Id = 1000 };  //this represents Jack after he changed his last name
            Employee Mike = new Employee() { FirstName = "Mike", LastName = "McDaniels", Id = 1001 };

            bool isSame = Jack == Mike; //id of jack == id of mike? using overloaded ==
            bool isDif = Jack != Mike;  //uses counterpart overloaded operator !=
            bool isSame2 = Jack == Jack2;  
            
            Console.WriteLine("Ids of Jack and Mike are the same: " + isSame);  //should read False, True, True
            Console.WriteLine("Ids of Jack and Mike are different: " + isDif);
            Console.WriteLine("Ids of Mike before and after changing last name are the same: " + isSame2);

            Console.ReadLine();
        }
    }
}
