namespace GreedKata
{
    public class OnesTripleScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public OnesTripleScoreCalculationStrategy() : base(die: 1, countOfDie: 3, scoreValue: 1000) { }
    }
}