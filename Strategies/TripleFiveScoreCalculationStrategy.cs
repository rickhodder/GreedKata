namespace GreedKata.Strategies
{
    public class TripleFiveScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleFiveScoreCalculationStrategy() : base(die: 5, countOfDie: 3, scoreValue: 500) { }
    }
}