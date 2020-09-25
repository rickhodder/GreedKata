using System;
using Xunit;

namespace GreedKata
{
    public class GreedGameTests
    {
        [Fact]
        public void Score_ShouldReturnZero()
        {
            var game = new GreedGame();  
            var roll = new Roll();                      
            Assert.Equal(0,game.Score(roll));
        }
    }
}
