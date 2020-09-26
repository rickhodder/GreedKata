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