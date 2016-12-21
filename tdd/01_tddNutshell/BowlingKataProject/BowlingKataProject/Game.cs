using System;


namespace BowlingKataProject
{
    public class Game
    {
        private int score = 0;

        public void roll(int pins)
        {
            score += pins;
        }

        public int scoreGame()
        {
            return score;
        }
    }
}
