namespace GreedKata
{
    public class ThreesTripleScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreesTripleScoreCalculationStrategy() : base(die: 2, countOfDie: 3, scoreValue: 200) { }
    }
}