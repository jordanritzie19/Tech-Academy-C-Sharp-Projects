using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee() { id = 1000, FirstName = "Tanisha", LastName = "Mahsa" };  //instantiating 10 employees, 2 with first name Joe
            Employee two = new Employee() { id = 1001, FirstName = "Kleitos", LastName = "Anatu" };
            Employee three = new Employee() { id = 1002, FirstName = "Vivek", LastName = "Stoiko" };
            Employee four = new Employee() { id = 1003, FirstName = "Phraates", LastName = "Metis" };
            Employee five = new Employee() { id = 1004, FirstName = "Angelica", LastName = "Vasilisa" };
            Employee six = new Employee() { id = 1005, FirstName = "Joe", LastName = "Schubert" };
            Employee seven = new Employee() { id = 1006, FirstName = "Piety", LastName = "Ruben" };
            Employee eight = new Employee() { id = 1007, FirstName = "Camila", LastName = "Bernie" };
            Employee nine = new Employee() { id = 1008, FirstName = "Youri", LastName = "Madelina" };
            Employee ten = new Employee() { id = 1009, FirstName = "Joe", LastName = "Esther" };

            List<Employee> employees = new List<Employee>() { one, two, three, four, five, six, seven, eight, nine, ten };  //putting them all in a list
            
            List<Employee> joes = new List<Employee>();  //blank list to fill
            foreach (Employee employee in employees)  //go through each employee in the list
            {
                if (employee.FirstName == "Joe")  //checking if first name is joe
                {
                    joes.Add(employee);  //if it is add it to the new list
                }
            }

            //Using Lambda functions to parse List
            List<Employee> joesL = employees.Where(x => x.FirstName == "Joe").ToList();  //creates a new list, where elements with FirstName Joe in employees list are placed

            List<Employee> greaterThan1004 = employees.Where(x => x.id > 1004).ToList();  //creates new list, where elements with id greater than 1004 in employees list are placed


            Console.ReadLine();  //pauses program
        }

    }
}
