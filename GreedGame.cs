using System.Linq;
using System.Collections.Generic;

namespace GreedKata
{
    public class GreedGame
    {
        public int Score(Roll roll)
        {
            return ScoreCalculator.CalculateScore(roll);
        }
    }

   public class Roll
    {
        public int[] Dice { get; set; } = new int[5];

        public int CountOfDie(int die)
        {
            return Dice.Count(d=>d==die);
        }
    }

    public interface IScoreCalculationStrategy
    {
        int CalculateScore(Roll roll);
    }

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

    public class OnesSingleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.CountOfDie(1);

            if (count < 3)
            {
                return score + (count * 100);
            }

            return score + ((count - 3) * 100);
        }
    }

    public class OnesTripleScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public OnesTripleScoreCalculationStrategy(): base(die:1, countOfDie:3, scoreValue:1000) {}
    }

    public class FivesSingleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.CountOfDie(5);

            if (count < 3)
            {
                return score + (count * 50);
            }

            return score + ((count - 3) * 50);
        }
    }

    public class FivesTripleScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public FivesTripleScoreCalculationStrategy(): base(die:5, countOfDie:3, scoreValue:500) {}
    }

    public class ThreeOnesGet1000ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.CountOfDie(1) == 3 ? 1000 : 0;
        }
    }

    public class ThreeTwosGets200ScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreeTwosGets200ScoreCalculationStrategy() : base(die:2, countOfDie:3, scoreValue:200) {}
    }

    public class ThreeThreesGets300ScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreeThreesGets300ScoreCalculationStrategy(): base(die:3, countOfDie:3, scoreValue:300) {}
    }

    public class ThreeFoursGets400ScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreeFoursGets400ScoreCalculationStrategy():base(die:4, countOfDie:3,scoreValue:400){}
    }

    public class ThreeSixesGets600ScoreCalculationStrategy : NthDieScoreCalculationStrategy
    {
        public ThreeSixesGets600ScoreCalculationStrategy(): base(die:6, countOfDie:3, scoreValue:600){}
    }

    public class ScoreCalculator
    {
        private static List<IScoreCalculationStrategy> _calculationStrategies
        = new List<IScoreCalculationStrategy>
            {
                new OnesSingleScoreCalculationStrategy(),
                new OnesTripleScoreCalculationStrategy(),
                new FivesSingleScoreCalculationStrategy(),
                new FivesTripleScoreCalculationStrategy(),
                new ThreeTwosGets200ScoreCalculationStrategy(),
                new ThreeThreesGets300ScoreCalculationStrategy(),
                new ThreeFoursGets400ScoreCalculationStrategy(),
                new ThreeSixesGets600ScoreCalculationStrategy()
            };

        public static int CalculateScore(Roll roll)
        {
            var score = 0;

            foreach (var strategy in _calculationStrategies)
            {
                score += strategy.CalculateScore(roll);
            }
            return score;
        }
    }
}