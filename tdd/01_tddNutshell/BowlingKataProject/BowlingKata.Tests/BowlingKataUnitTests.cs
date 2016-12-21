using System;
using BowlingKataProject;
using Xunit;

namespace BowlingKata.Tests
{
    public class BowlingKataUnitTests
    {
        //arrange

        //act  
       
        //assert

        [Fact]
        public void DoesGameExist()
        {
            //arrange
            Game g;

            //act
            g = new Game();

            //assert
            Assert.NotNull(g);
        }
        [Fact]
        public void GutterGameReturns0()
        {
            //arrange
            Game g = new Game();
            int pins = 0;

            //act  
            for (int i = 0; i < 20; i++)
            {
                g.roll(pins);
            }

            //assert
            Assert.Equal(0, g.scoreGame());
        }
    }
}
