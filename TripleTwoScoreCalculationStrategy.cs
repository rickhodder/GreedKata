namespace GreedKata
{
    public class TripleTwoScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public TripleTwoScoreCalculationStrategy() : base(die: 2, countOfDie: 3, scoreValue: 200) { }
    }
}