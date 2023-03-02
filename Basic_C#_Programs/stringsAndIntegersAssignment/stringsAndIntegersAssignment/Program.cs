using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> dividends = new List<int>() { 4, 8, 12, 16, 20, 24 }; //starting list
                List<int> quotients = new List<int>();  //the results after dividing
                Console.WriteLine("Here's our current list: ");
                Console.WriteLine(string.Join(", ", dividends));  //combines each element in a list into a concatenated string
                Console.WriteLine("What number should we divide our list by?");
                int divisor = Convert.ToInt32(Console.ReadLine());  //this is what our list gets divided by
                foreach (int dividend in dividends)
                {
                    int quotient = dividend / divisor; //each element in the list gets divided by the inputted divisor
                    quotients.Add(quotient);  //this number then goes into a new list to be printed out later
                }
                Console.WriteLine("Here is our new list: ");
                Console.WriteLine(string.Join(", ", quotients)); //prints out our new list after the division is complete
                Console.ReadLine();
            }
            catch (FormatException ex)  //checks if input is in the correct format (integer)
            {
                Console.WriteLine("Thats not a whole number... try again");
                return;
            }
            catch (DivideByZeroException ex)  //checks if input is 0, as you can't divide by zero
            {
                Console.WriteLine("We can't divide by zero!");
            }
            catch (Exception ex)  //this catches any other errors
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("glad we got through that one..."); //finally block always runs
            }
            Console.WriteLine("this is the rest of the program running, IF I HAD ONE"); //outside the try/catch, only runs if the try succeeds.
            Console.ReadLine();  //pauses the console
        }
    }
}
