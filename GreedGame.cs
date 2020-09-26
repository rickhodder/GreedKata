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
        int CalculateScore(Roll roll) ;
    }

    public class EachOnesGet100ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==1)==1 ? 100 : 0;
        }
    }

    public class ThreeOnesGet1000ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==1)==3 ? 1000 : 0;
        }
    }

    public class ThreeTwosGets200ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==2)==3 ? 200 : 0;
        }
    }

    public class ThreeThreesGets300ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==3)==3 ? 300 : 0;
        }
    }

    public class ThreeFoursGets400ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==4)==3 ? 400 : 0;
        }
    }

    public class ThreeFivesGets500ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==5)==3 ? 500 : 0;
        }
    }

    public class EachFiveGets50ScoreCalculationStrategy : IScoreCalculationStrategy
    {
        public int CalculateScore(Roll roll)
        {
            return roll.Dice.Count(d=>d==5)==1 ? 50 :0;
        }
    }

    public class ScoreCalculator
    {
        private static List<IScoreCalculationStrategy> _calculationStrategies 
        = new List<IScoreCalculationStrategy>
            {
                new EachOnesGet100ScoreCalculationStrategy(),
                new EachFiveGets50ScoreCalculationStrategy(),
                new ThreeOnesGet1000ScoreCalculationStrategy(),
                new ThreeTwosGets200ScoreCalculationStrategy(),
                new ThreeThreesGets300ScoreCalculationStrategy(),
                new ThreeFoursGets400ScoreCalculationStrategy(),
                new ThreeFivesGets500ScoreCalculationStrategy()
            };

        public static int CalculateScore(Roll roll)
        {
            var score = 0;

            foreach (var strategy in _calculationStrategies)
            {
                score+=strategy.CalculateScore(roll);
            }

            return score;

        }

    }

    public class Roll
    {
        public int[] Dice { get; set; } = new int[5];
    }
}