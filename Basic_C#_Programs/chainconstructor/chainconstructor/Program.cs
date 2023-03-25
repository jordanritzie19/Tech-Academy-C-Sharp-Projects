using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainconstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string welcome = "Welcome to now";
            Console.WriteLine("{0}, What's your name? ",welcome);  //prompts for name
            string name = Console.ReadLine();  //holds name

            Player player = new Player(name);  //instantiates player with only name, this should use default bank
            Console.WriteLine("Hi {0}, your balance is: {1} dollars",player.Name,player.Bank);   //this should read '100'
            var joey = new Player("joey", 520);   //uses var to instantiate a player class passing both values
            Console.WriteLine(joey.Name + ": " + joey.Bank);  //should print joey: 520

            Console.ReadLine(); 
        }
    }
}
