namespace GreedKata.Strategies
{
    public class TripleSixesScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleSixesScoreCalculationStrategy() : base(die: 6, countOfDie: 3, scoreValue: 600) { }
    }
}