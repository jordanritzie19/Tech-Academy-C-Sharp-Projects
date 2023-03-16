using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daysofTheWeekEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it? (capitalize first letter)");
            try
            {
                if (Enum.TryParse(Console.ReadLine(), out DaysoftheWeek day))
                {
                    Console.WriteLine("Oh its " + day + "? For some reason, I thought that was yesterday.");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
