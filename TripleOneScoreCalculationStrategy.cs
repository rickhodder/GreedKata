namespace GreedKata
{
    public class TripleOneScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleOneScoreCalculationStrategy() : base(die: 1, countOfDie: 3, scoreValue: 1000) { }
    }
}