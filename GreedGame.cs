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

    public interface IScoreCalculationStrategy
    {
        int CalculateScore(Roll roll);
    }

    public class OnesSingleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.Dice.Count(d => d == 1);

            if (count < 3)
            {
                return score + (count * 100);
            }

            return score + ((count - 3) * 100);
        }
    }

    public class OnesTripleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var count = roll.Dice.Count(d => d == 1);

            return (count < 3) ? 0 : 1000;
        }
    }

    public class FivesSingleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var score = 0;
            var count = roll.Dice.Count(d => d == 5);

            if (count < 3)
            {
                return score + (count * 50);
            }

            return score + ((count - 3) * 50);
        }
    }

    public class FivesTripleScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            var count = roll.Dice.Count(d => d == 5);

            return (count < 3) ? 0 : 500;
        }
    }

    public class ThreeOnesGet1000ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d => d == 1) == 3 ? 1000 : 0;
        }
    }

    public class ThreeTwosGets200ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d => d == 2) == 3 ? 200 : 0;
        }
    }

    public class ThreeThreesGets300ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d => d == 3) == 3 ? 300 : 0;
        }
    }

    public class ThreeFoursGets400ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d => d == 4) == 3 ? 400 : 0;
        }
    }

    public class ThreeSixesGets600ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d => d == 6) == 3 ? 600 : 0;
        }
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

    public class Roll
    {
        public int[] Dice { get; set; } = new int[5];
    }
}