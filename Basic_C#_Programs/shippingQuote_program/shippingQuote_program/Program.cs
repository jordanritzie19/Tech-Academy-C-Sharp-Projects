using System;


namespace shippingQuote_program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Enter package weight in pounds: ");  //asking for variable inputs
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter package width in inches: ");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter package height in inches: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter package length in inches: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int dimensions = width + height + length; //this gets used in branching statement below

                if (dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express."); //errors out if dimensions too large
                }
                else
                {
                    decimal quote = (height * width * length * weight) / 100.00M;  //gets quote value
                    Console.WriteLine("$" + quote.ToString("0.00")); //takes quote and writes it as money, to 2 decimal places as expected
                }
            }
            Console.ReadLine();  //keeps console open
        }
    }
}
