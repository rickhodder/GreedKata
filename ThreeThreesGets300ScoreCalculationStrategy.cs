namespace GreedKata
{
    public class ThreeThreesGets300ScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreeThreesGets300ScoreCalculationStrategy() : base(die: 3, countOfDie: 3, scoreValue: 300) { }
    }
}