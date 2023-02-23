using System;

namespace carInsuranceQualification_program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //gets a value for age

            Console.WriteLine("Have you ever had a DUI? Answer \"True\" or \"False\"");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());  //gets a boolean value for whether or not you've had a DUI

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());  //gets number of speeding tickets

            bool isQualified = age > 15 && hadDUI == false && tickets <= 3;  //checks if eligible for car insurance
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified); //if qualified prints true, else false
            Console.ReadLine();  //keeps console open
        }
    }
}
