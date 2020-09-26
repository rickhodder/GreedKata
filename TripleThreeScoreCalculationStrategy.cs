namespace GreedKata
{
    public class TripleThreeScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleThreeScoreCalculationStrategy() : base(die: 3, countOfDie: 3, scoreValue: 300) { }
    }
}