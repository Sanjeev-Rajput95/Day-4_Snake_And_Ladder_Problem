using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Day4Problem
    {
       
        public const int  FORWARD_MOVE = 1;
        public const int  BACKWARD_MOVE = 2;
        public const int  NO_MOVE = 3;

        public void winningPosition()
        {
            int playerPosition1 = 0;
            int playerPosition2 = 0;
            int activePlayer = 1;
            int count = 0;

            Random random = new Random();  

            while(playerPosition1 < 100 && playerPosition2 <100)
            {
                count = count + 1;
                int movingCheck = random.Next(1, 4);
                int stepCheck = random.Next(1, 7);
                Console.WriteLine(" this is moving check " + movingCheck);
                Console.WriteLine(" this is step check " + stepCheck);
                switch (movingCheck)
                {
                    case FORWARD_MOVE:
                        if (activePlayer == 1)
                        {
                            if ((playerPosition1 + stepCheck) <= 100)
                            {
                                playerPosition1 = playerPosition1 + stepCheck;
                                Console.WriteLine(" Forward move ");
                            }
                        }
                        else
                        {
                            if ((playerPosition2 + stepCheck) <= 100)
                            {
                                playerPosition2 = playerPosition2 + stepCheck;
                                Console.WriteLine(" Forward move ");
                            }
                        }                      
                        break;
                    case BACKWARD_MOVE:
                        if (activePlayer == 1)
                        {
                            if (playerPosition1 > 0)
                            {
                                playerPosition1 = playerPosition1 - stepCheck;
                                Console.WriteLine(" Backward move ");
                            }
                            activePlayer = 2;
                        }
                        else
                        {
                            if (playerPosition2 > 0)
                            {
                                playerPosition2 = playerPosition2 - stepCheck;
                                Console.WriteLine(" Backward move ");
                            }
                            activePlayer = 1;
                        }
                        break;
                    case NO_MOVE:
                        if (activePlayer == 1)
                        {
                            activePlayer = 2;
                        }
                        else
                        {
                            activePlayer = 1;
                        }
                        Console.WriteLine("No move ");
                        break;
                }
                Console.WriteLine("Number of Dice roll = " + count);
            }
            Console.WriteLine( playerPosition1 + " step count of player1 ");
            Console.WriteLine( playerPosition2 + " step count of player2 ");

            if (playerPosition1 == 100 )
            {
                Console.WriteLine("Player 1 is WIN : " + playerPosition1 );
            }
            else
            {
                Console.WriteLine("Player 2 is WIN : " + playerPosition2 );
            }
            Console.WriteLine("Number of Dice roll = " + count);

        }
    }
}
