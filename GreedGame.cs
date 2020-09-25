using System.Linq;

namespace GreedKata
{
    public class GreedGame
    {
        public int Score(Roll roll)
        {
            if (roll.Dice.Any(d=>d==1))
            {
                return 100;
            }
 
            if (roll.Dice.Any(d=>d==5))
            {
                return 50;
            }

            return 0;
        }
    }

    public class Roll
    {
        public int[] Dice { get; set; } = new int[5];
    }
}