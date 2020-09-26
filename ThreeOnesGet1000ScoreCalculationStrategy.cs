namespace GreedKata
{
    public class ThreeOnesGet1000ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.CountOfDie(1) == 3 ? 1000 : 0;
        }
    }
}