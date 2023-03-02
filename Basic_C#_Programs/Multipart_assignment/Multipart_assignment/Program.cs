using System;
using System.Collections.Generic;


namespace Multipart_assignment
{
    class Program
    {
        static void Main()
        {
            // Part 1
            Console.WriteLine("Part 1: ");
            string[] stray = { "one ", "two ", "three ", "four ", "five " };
            Console.WriteLine("input a noun");
            string noun = Console.ReadLine().ToLower();   //to make input not case-sensitive
            for (int i = 0; i < stray.Length; i++)        //goes through each index and appends noun input through string concatenation
            {
                stray[i] = stray[i] + noun;
            }
            for (int j = 0; j < stray.Length; j++)        //goes through each index, and prints its value
            {
                Console.WriteLine(stray[j]);
            }
            Console.ReadLine();   //pauses part 1 until ready to move on


            //Part 2
            Console.WriteLine("Part 2: ");
            int num1 = 1;
            while (num1 > 0 & num1 < 5) //gave an upper-bound for the loop to stop at
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.ReadLine();  //pauses part 2 until ready to move on


            //Part 3
            Console.WriteLine("Part 3: ");
            int num2 = 5;
            while (num2 < 8)   //keeps iterating until 8 is reached
            {
                Console.WriteLine(num2);
                num2++;
            }
            while (num2 <= 12)  //takes number from previous loop, and further iterates until 12 is passed
            {
                Console.WriteLine(num2 + " in the second loop");
                num2++;
            }
            Console.ReadLine();  //pauses part 3 until ready to move on


            //Part 4
            Console.WriteLine("Part 4: ");
            List<string> Fruits = new List<string>() { "apple", "banana", "orange", "watermelon", "strawberry" };
            Console.WriteLine("Guess a fruit thats on this list");
            string guess = Console.ReadLine().ToLower();  //to make input not case-sensitive
            for (int i = 0; i < Fruits.Count; i++)
            {
                if (Fruits[i] == guess)
                {
                    Console.WriteLine("That fruit is in index " + i);
                    break;                              //ends the loop
                }
            }
            if (!Fruits.Contains(guess))
            {
                Console.WriteLine("That fruit isn't on the list, sorry");
            }
            Console.ReadLine();  
            //pauses part 4 until ready to move on


            //Part 5
            Console.WriteLine("Part 5: ");
            List<string> Sports = new List<string>() { "soccer", "football", "baseball", "basketball", "hockey", "soccer" };
            Console.WriteLine("Guess a sport thats on this list");
            string guess2 = Console.ReadLine().ToLower();
            int checkMatch = 0;   //this is variable that keeps track of how many non-matches there were
            for (int j = 0; j < Sports.Count; j++)
            {
                if (Sports[j] == guess2)
                {
                    Console.WriteLine("That sport is in index " + j);
                }
                else
                {
                    checkMatch++;  //since there wasn't a match, we increase this counter by 1
                    // if a match was met this condition would be skipped and checkMatch could never == sports.Count
                }

                if (checkMatch == Sports.Count)  //if every iteration didn't lead to a match, then the input wasn't on the list
                {
                    Console.WriteLine("That sport isn't on the list, sorry");
                }
            }
            Console.ReadLine();   //pauses part 5 until ready to move on


            //Part 6
            Console.WriteLine("Part 6: ");
            List<string> colors = new List<string>() { "blue", "red", "yellow", "red", "blue", "purple" };
            List<string> usedColors = new List<string>();  //creates a new list to check through
            foreach (string color in colors)  //goes through each item in colors list 
            {
                usedColors.Add(color);
                if (usedColors.Count == 1)  //this was necessary because I don't want to check the newly added color below
                {
                    Console.WriteLine(color + " - this item is unique");
                }
                for (int k = usedColors.Count - 2; k > -1; k--)  //starting with previous color, goes backwards through list to check for matches, stopping at index 0
                {
                    if (usedColors[k] == color)  //this if statement is the case where a match was found
                    {
                        Console.WriteLine(color + " - this item is a duplicate");
                        break;
                    }
                    if (k == 0)  //this if statement is the case where every item on the list has been iterated through
                    {
                        Console.WriteLine(color + " - this item is unique");
                    }
                }
            }
            Console.ReadLine();  //this keeps the console open
        }
    }
}
