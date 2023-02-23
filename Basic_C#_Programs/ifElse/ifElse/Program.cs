using System;

namespace ifElse
{
    class Program
    {
        static void Main()
        {
            if (1 > 2)
            {
                Console.WriteLine("1 is greater than 2?");
            }
            else if (1 == 2)
            {
                Console.WriteLine("how on earth is 1 equal to 2????");
            }
            else
            {
                Console.WriteLine("1 is not greater than 2...");
            }

            string result = (1 > 2) ? "Liar..." : "Congrats on this very easy question";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
