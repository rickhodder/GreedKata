namespace GreedKata
{
    public class SingleFiveScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.CountOfDie(5);

            if (count < 3)
            {
                return score + (count * 50);
            }

            return score + ((count - 3) * 50);
        }
    }
}