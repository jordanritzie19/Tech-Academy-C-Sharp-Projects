using System;

namespace IncomeComparison_program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("-----------------");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("Person 1's Hourly Rate: ");
            int p1Rate = Convert.ToInt32(Console.ReadLine());  //input value for hourly rate
            Console.WriteLine("Person 1's Weekly Hours: ");
            int p1Hours = Convert.ToInt32(Console.ReadLine()); //input value for hours per week

            Console.WriteLine("-----------------");
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Person 2's Hourly Rate: ");  //... for person 2
            int p2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2's Weekly Hours: ");
            int p2Hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------");
            Console.WriteLine("Annual Salary of Person 1: ");
            int p1Salary = p1Rate * p1Hours * 52; //52 weeks in a year, this is just a simplified version
            Console.WriteLine(p1Salary);
            Console.WriteLine("Annual Salary of Person 2: ");
            int p2Salary = p2Rate * p2Hours * 52;
            Console.WriteLine(p2Salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isPaidMore = p1Salary > p2Salary;  //this gives 'True' or 'False'
            Console.WriteLine(isPaidMore);   
            Console.ReadLine(); //keeps console open

        }
    }
}
