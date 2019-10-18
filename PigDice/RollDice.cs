using System;
using System.Collections.Generic;
using System.Text;

namespace PigDice
{
    public class RollDice
    {
        int CurrentScore = 0;
        int OverallScore = 0;

        public int GetCurrentScore()
        {
            return CurrentScore;
        }

        public int GetOverallScore()
        {
            return OverallScore;
        }
        public RollDice()
        {

        }
        public int generate() // generating 2 random numbers
        {
            Random dice = new Random();
            int Dice1 = dice.Next(1, 7);
            int Dice2 = dice.Next(1, 7);
            int Score = 0;
                if (Dice1 != 1 && Dice2 != 1)
                {
                    Score += (Dice1 + Dice2);
                }
                else { Score = 0; }
            
            Console.WriteLine($"Your dice numbers are {Dice1} and {Dice2}");
          
            return Score; 
        }

        public ConsoleKey Play()
        {

            ConsoleKey type = ConsoleKey.A;
            while (OverallScore < 99)
            {
               
                type = Console.ReadKey().Key;
                Console.Clear();

                int tempScore = generate();

                if (tempScore != 0)
                {
                    CurrentScore += tempScore; 
                }
                else CurrentScore = 0; 

                if (type == ConsoleKey.H)
                {
                    OverallScore += CurrentScore;
                    CurrentScore = 0; 
                }

                Console.WriteLine($"Current Score is {CurrentScore}");
                Console.WriteLine($"Overall Score is {OverallScore}");
            }
            

            if (OverallScore > 99)
            {
                Console.WriteLine("You Won!");  
            }

            return type;

        }
    }

}
