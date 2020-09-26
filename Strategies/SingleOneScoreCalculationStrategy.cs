using GreedKata.Interfaces;

namespace GreedKata.Strategies
{
    public class SingleOneScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.CountOfDie(1);

            if (count < 3)
            {
                return score + (count * 100);
            }

            return score + ((count - 3) * 100);
        }
    }
}