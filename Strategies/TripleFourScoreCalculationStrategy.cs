namespace GreedKata.Strategies
{
    public class TripleFourScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleFourScoreCalculationStrategy() : base(die: 4, countOfDie: 3, scoreValue: 400) { }
    }
}