using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming_ConsoleGame
{
    public class Score
    {
        public int GameScore { get; set; }
        public Score()
        {
            GameScore = 20;
        }

        public int GetScore()
        {
            return GameScore;
        }

        public void CorrectAnswer()
        {
            GameScore += 10;
        }

        public void IncorrectAnswer()
        {
            GameScore -= 10;
        }

        public void PrintScore()
        {
            Console.WriteLine($"Your score: {GameScore}");
        }
    }
}
