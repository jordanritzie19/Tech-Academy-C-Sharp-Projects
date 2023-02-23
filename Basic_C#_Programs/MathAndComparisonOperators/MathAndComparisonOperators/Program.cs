using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five  = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //comparison operators

            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse);
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //// bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //do math on input values

            Console.WriteLine("Give me a number to multiply: ");  //first line each segment asks for an input
            int timesNumber = Convert.ToInt32(Console.ReadLine());  //and the second line converts that input into an integer that we can work with
            int times50 = timesNumber * 50;   //the third line does the appropriate operation
            Console.WriteLine(timesNumber + " * 50 equals " + times50);  //and the last line prints out the results

            Console.WriteLine("Give me a number to add: ");
            int addNumber = Convert.ToInt32(Console.ReadLine());
            int add25 = addNumber + 25;
            Console.WriteLine(addNumber + " + 25 equals " + add25);

            Console.WriteLine("Give me a number to divide: ");
            int divideNumber = Convert.ToInt32(Console.ReadLine());
            double divideDouble = divideNumber / 12.5;    //this is a double, because int types dont have decimal points
            Console.WriteLine(divideNumber + " / 12.5 " + "equates to " + divideDouble);

            Console.WriteLine("Give me a number, and I'll let you know if it is greater than 50: ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            bool isGreaterThan = checkNumber > 50;   //this is a boolean because we are seeing if a statement is true or false
            Console.WriteLine("It is " + isGreaterThan + " that " + checkNumber + " is greater than 50.");

            Console.WriteLine("Give me a number so I can test the modulus operator: ");
            int modularity = Convert.ToInt32(Console.ReadLine());
            int remainder = modularity % 7;
            Console.WriteLine(modularity + " / 7 has a remainder of " + remainder);

            Console.ReadLine(); //this line is just so the program doesnt immediately end before you can read last questions results.
        }
    }
}
