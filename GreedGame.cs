using System.Linq;

namespace GreedKata
{
    public class GreedGame
    {
        public int Score(Roll roll)
        {
            var score = 0;

            if (roll.Dice.Count(d=>d==1)==3)
            {
                score+=1000;
            }

            if (roll.Dice.Count(d=>d==1)==1)
            {
                score+=100;
            }
 
            if (roll.Dice.Any(d=>d==5))
            {
                score+= 50;
            }

            return score;
        }
    }

    public class Roll
    {
        public int[] Dice { get; set; } = new int[5];
    }
}