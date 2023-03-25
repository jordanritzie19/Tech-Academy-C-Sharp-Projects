using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainconstructor
{
    public class Player
    {
        public Player() : this("Jordan", 100)  //if no arguments, use these values
        {  //thisll just use the same code as the constructor below
        }
        public Player(string name, int bank)  //..both arguments
        {
            this.Name = name;
            this.Bank = bank;
        }
        public Player(string name) : this(name, 100)  //if only name is passed thorugh, set bank to 100
        {  //same code as constructor above
        }
        

        public string Name { get; set; }
        public int Bank { get; set; }
    }
}

