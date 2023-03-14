using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)  //takes in 2 employee objects
        {
            return employee1.Id == employee2.Id;  //and returns boolean of id1 == id2
        }
        public static bool operator !=(Employee employee1, Employee employee2)  //overloaded == means != needs defined as well
        {
            return employee1.Id != employee2.Id;
        }

        // resolved warning using this link: https://learn.microsoft.com/en-us/dotnet/csharp/misc/cs0660?f1url=%3FappId%3Droslyn%26k%3Dk(CS0660)  
        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
        //end of code resolving warning
    }
}
