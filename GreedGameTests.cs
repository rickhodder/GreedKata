using System;
using Xunit;

namespace GreedKata
{
    public class GreedGameTests
    {
        private GreedGame _game;
        private Roll _roll;

        public GreedGameTests()
        {
            _game = new GreedGame();
            _roll = new Roll();
        }

        [Fact]
        public void Score_ShouldReturnZero()
        {
            _roll.Dice = new int[] { 2, 3, 4, 6, 6 };
            Assert.Equal(0, _game.Score(_roll));
        }

        [Fact]
        public void Score_ContainsOne_ShouldReturn100()
        {
            _roll.Dice = new int[] { 1, 2, 3, 4, 6 };
            Assert.Equal(100, _game.Score(_roll));
        }

        [Fact]
        public void Score_ContainsFive_ShouldReturn50()
        {
            _roll.Dice = new int[] { 2, 2, 3, 4, 5 };
            Assert.Equal(50, _game.Score(_roll));
        }

        [Fact]
        public void Score_ContainsOneAndFive_ShouldReturn150()
        {
            _roll.Dice = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(150, _game.Score(_roll));
        }

        [Fact]
        public void Score_ContainsThreeOnes_ShouldReturn1000()
        {
            _roll.Dice = new int[] { 1, 1, 3, 4, 1 };
            Assert.Equal(1000, _game.Score(_roll));
        }

        [Fact]
        public void Score_ContainsThreeTwos_ShouldReturn200()
        {
            _roll.Dice = new int[] { 2, 2, 2, 3, 4 };
            Assert.Equal(200, _game.Score(_roll));
        }       

        [Fact]
        public void Score_ContainsThreeThrees_ShouldReturn300()
        {
            _roll.Dice = new int[] { 3, 3, 3, 4, 4 };
            Assert.Equal(300, _game.Score(_roll));
        }       

        [Fact]
        public void Score_ContainsThreeFours_ShouldReturn400()
        {
            _roll.Dice = new int[] { 6, 6, 4, 4, 4 };
            Assert.Equal(400, _game.Score(_roll));
        }       

        [Fact]
        public void Score_ContainsThreeFives_ShouldReturn500()
        {
            _roll.Dice = new int[] { 6, 6, 5, 5, 5 };
            Assert.Equal(500, _game.Score(_roll));
        }       

        [Theory]
        [InlineData(1,1,1,5,1,1150)]
        [InlineData(2,3,4,6,2,0)]
        [InlineData(3,4,5,3,3,350)]
        public void Score_ExampleTests_ShouldSucceed(int die1, int die2, int die3, int die4, int die5, int result)
        {
            _roll.Dice = new int[] { die1, die2, die3, die4, die5 };
            Assert.Equal(result, _game.Score(_roll));
        }       

        [Fact]
        public void Score_ContainsThreeSixes_ShouldReturn600()
        {
            _roll.Dice = new int[] { 6, 6, 6, 3, 4 };
            Assert.Equal(600, _game.Score(_roll));
        }       

    }
}
