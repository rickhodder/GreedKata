using GreedKata.Interfaces;

namespace GreedKata.Strategies
{
    public class NthDieScoreCalculationStrategy : IScoreCalculationStrategy
    {
        private readonly int _die;
        private readonly int _countOfDie;
        private readonly int _scoreValue;

        public NthDieScoreCalculationStrategy(int die, int countOfDie, int scoreValue)
        {
            _die = die;
            _countOfDie = countOfDie;
            _scoreValue = scoreValue;
        }
        public int CalculateScore(Roll roll)
        {
            return (roll.CountOfDie(_die) >= _countOfDie) ? _scoreValue : 0;
        }
    }
}