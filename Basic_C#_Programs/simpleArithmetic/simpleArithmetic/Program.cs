using System;


namespace simpleArithmetic
{
    class Program
    {
        static void Main()
        {
            int num1 = 4;
            int num2 = 2;

            int AddTwo = num1 + num2;
            int MinusTwo = num1 - num2;
            int TimesTwo = num1 * num2;
            int DivideTwo = num1 / num2;

            Console.WriteLine("Take 2 numbers, lets say " + num1 + " and " + num2);
            Console.WriteLine("If you add them, you'd get " + AddTwo);
            Console.WriteLine("But if you subtract, you get " + MinusTwo);
            Console.WriteLine("Multiplying them leaves you with " + TimesTwo);
            Console.WriteLine("And the numbers divided results in " + DivideTwo + " as well.");
            Console.WriteLine("As you can see, there are many ways to manipulate numbers; these are the very basics.");
            Console.ReadLine();

        }
    }
}
