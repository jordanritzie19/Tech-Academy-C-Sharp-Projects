using System;
using System.Collections.Generic;


namespace ArrayList_exercise
{
    class Program
    {
        static void Main()
        {
            string[] Instruments = { "Piano", "Trumpet", "Guitar", "Flute", "Violin" };
            int[] indexArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<string> notes = new List<string>();
            notes.Add("A");
            notes.Add("B");
            notes.Add("C");
            notes.Add("D");
            notes.Add("E");
            notes.Add("F");
            notes.Add("G");

            Console.WriteLine("Select an index of the Instruments Array (0 through 4)");
            int selection1 = Convert.ToInt32(Console.ReadLine());
            if (selection1 >= 0 && selection1 <= 4)
            {
                Console.WriteLine("That instrument is a " + Instruments[selection1]);
            }
            else
            {
                Console.WriteLine("That index doesnt exist <.<");
            }

            Console.WriteLine("Select an index of the Index Array (0 through 9)");
            int selection2 = Convert.ToInt32(Console.ReadLine());
            if (selection2 >= 0 && selection2 <= 9)
            {
                Console.WriteLine("You chose index " + indexArray[selection2]);
            }
            else
            {
                Console.WriteLine("That index doesnt exist >.>");
            }

            Console.WriteLine("Select an index of the Notes List (0 through 6)");
            int selection3 = Convert.ToInt32(Console.ReadLine());
            if (selection3 >= 0 && selection3 <= 6)
            {
                Console.WriteLine("You selected " + notes[selection3]);
            }
            else
            {
                Console.WriteLine("That index doesnt exist >.<");
            }
            Console.ReadLine();
        }
    }
}
