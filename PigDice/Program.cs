using System;

namespace PigDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player 1
            int Player1OverallScore = 0;
            
            //Player2
            int Plyaer2OverallScore = 0;

           

            RollDice player1 = new RollDice();
            RollDice player2 = new RollDice();

            string currentplayer = "player1";
            Console.WriteLine("\n Enter h to hold your points or any other key to roll again.");
            player1.Play();
            //if(player1. GetCurrentScore() == 0 )
            //{
            //    player2.Play();
            //}
            //else
            //{
                
            //}










        }

    }


  

       

    
}
