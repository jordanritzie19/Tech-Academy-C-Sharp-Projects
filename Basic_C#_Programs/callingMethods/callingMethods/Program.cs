using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number from 1-9");   //input single digit number
            int startingNumber = Convert.ToInt32(Console.ReadLine());  //inputted number
            try  //this makes sure that the chosen number is actually between 1 and 9
            {
                if (startingNumber > 9 || startingNumber < 1)
                {
                    throw new ArithmeticException("You chose a number outside the scope of this program.");
                }
            }
            catch (ArithmeticException er)
            {
                Console.WriteLine(er); //writes out the above arithmetic exception (line 19)
                Console.ReadLine();
                return;  //this ends the program
            }
            //I did not desire a finally{} in this case
            ModdedNumber guess = new ModdedNumber(startingNumber);  //sets the initial value of ModdedNumber 'guess' to inputted number from start of program
            Console.WriteLine("Take that number and multiply it by 3"); //this is just going through the steps for this math trick
            Console.ReadLine();
            Console.WriteLine("Now add 3 to that number"); 
            Console.ReadLine();
            Console.WriteLine("Multiply your new number by 3 once again");
            Console.ReadLine();
            Console.WriteLine("Add the digits together.");
            Console.ReadLine();
            Console.WriteLine("Is your new number... a " + guess.Value + "?"); //this should ALWAYS be a 9
            Console.ReadLine(); //keeps program open

        }
    }
}
