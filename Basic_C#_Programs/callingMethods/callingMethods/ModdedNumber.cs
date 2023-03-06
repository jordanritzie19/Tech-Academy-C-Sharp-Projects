using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    public class ModdedNumber
    {
        public ModdedNumber(int initial)  //constructor with parameter of an initial number to modify
        {
            Value = TimesThree(initial);  //multiplies initial number by 3
            Value = PlusThree(Value);    //adds 3
            Value = TimesThree(Value);  //...
            Value = GetIntArray(Value)[0] + GetIntArray(Value)[1]; //adds the two digits together.


            // methods
            int PlusThree(int num)  //takes in an argument for parameter num, and adds 3 to it
            {
                num = num + 3;
                return num;
            }
            int TimesThree(int num) //takes in argument for parameter num, multiplying it by 3
            {
                num = num * 3;
                return num;
            }
            int[] GetIntArray(int num) //adds the 2 digits together
            {
                List<int> listOfInts = new List<int>(); //this is what the separated number goes into
                while (num > 0) //'chop' a number until theres nothing remaining
                {
                    //divide 10 and take remainder, in decimal system this is the same as taking the last digit of a number
                    listOfInts.Add(num % 10); //ex: 54 -> 50 % 10 = 4
                    //chop the last digit, integers always effectively round down
                    num = num / 10; // ex: 54/10 -> 5.4 (stored as integer '5')
                }
                listOfInts.Reverse(); //without this, 54 would be split into [4, 5] as 
                //our method starts from the end of the number, this reflects it back as [5, 4] as we want
                return listOfInts.ToArray();
            }
        }
        public int Value { get; } //this variable cannot be directly changed by 'main'
    }
}
