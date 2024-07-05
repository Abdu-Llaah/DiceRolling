using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNUM;
            int computerRandomNum;

            int playerPoints = 0;
            int computerPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNUM = random.Next(1, 7);
                Console.WriteLine("You rolloed a :" + playerRandomNUM);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(10000);

                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("Ai rolled a :" + computerRandomNum);

                if (playerRandomNUM > computerRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player win this round");
                }
                else if (playerRandomNUM < computerRandomNum)
                {
                    computerPoints++;
                    Console.WriteLine("The Computer won thos roud ");


                }

                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("The score is now - player :" + playerPoints + " .computer :" + computerPoints + ".");
                Console.WriteLine("");



                if (playerPoints > computerPoints)
                {
                    Console.WriteLine("You win!");
                }

                else if (playerPoints < computerPoints)
                {
                    Console.WriteLine("You loose! (Computer wins)");
                }

                else
                {
                    Console.WriteLine("Its a draw !");




                    Console.ReadKey();


                }
            }

        }
    }
}
    
