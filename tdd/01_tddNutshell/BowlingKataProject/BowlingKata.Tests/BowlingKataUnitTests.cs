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
        private Game g;

        public BowlingKataUnitTests()
        {
            g = new Game();
        }

        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.roll(pins);
            }
        }

        [Fact]
        public void DoesGameExist()
        {
            //arrange

            //act

            //assert
            Assert.NotNull(g);
        }
        [Fact]
        public void GutterGameReturns0()
        {
            //arrange

            //act  
            rollMany(20, 0);

            //assert
            Assert.Equal(0, g.scoreGame());
        }

        [Fact]
        public void SinglePinGameReturns20()
        {
            //arrange

            //act  
            rollMany(20, 1);

            //assert
            Assert.Equal(20, g.scoreGame());
        }
    }
}
