namespace GreedKata
{
    public class OnesSingleScoreCalculationStrategy : IScoreCalculationStrategy
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