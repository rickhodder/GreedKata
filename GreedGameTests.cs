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
            Assert.Equal(0,_game.Score(_roll));            
        }

        [Fact]
        public void Score_ContainsOne_ShouldReturn100()
        {
            _roll.Dice =new int[] {1,2,3,4,5};
            Assert.Equal(100,_game.Score(_roll));            
        }

        [Fact]
        public void Score_ContainsFive_ShouldReturn50()
        {
            _roll.Dice =new int[] {2,2,3,4,5};
            Assert.Equal(50,_game.Score(_roll));            
        }

    }
}
