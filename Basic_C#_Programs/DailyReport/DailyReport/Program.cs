using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");

            //report questions, asks a question, and prompts for a response
            Console.WriteLine("What is your name?");  //this is an example of a question
            string yourName = Console.ReadLine();   //your response gets stored in this variable
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveXP = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            //closer
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
