using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Day4Problem
    {
        public void singlePlayer()
        {
            int num_Of_Player = 1;
            int start_Position = 0;
        }
        public void firstDiceRoll()
        {
            Console.Write("First dice roll : ");
            Random random = new Random();
            Console.WriteLine(random.Next(1, 6));           
        }
    }
}
