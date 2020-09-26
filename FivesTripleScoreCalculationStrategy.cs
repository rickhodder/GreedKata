namespace GreedKata
{
    public class FivesTripleScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public FivesTripleScoreCalculationStrategy() : base(die: 5, countOfDie: 3, scoreValue: 500) { }
    }
}