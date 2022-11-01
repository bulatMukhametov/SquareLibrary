using SquareLibrary.Impl;
using SquareLibrary.Interfaces;
using System;
using Xunit;

namespace SquareLibrary.Tests
{
    public class SquareServiceTest
    {
        [Fact]
        public void ArgumentsTest()
        {
            ISquareService squareService = new SquareService();

            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(-1, 2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(1, -2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(1, 2, -3));

            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(new Circle(-1)));
            Assert.Throws<ArgumentOutOfRangeException>(() => squareService.GetSquare(new Triangle(1, 0, 2)));
        }

        [Fact]
        public void GetSquareTest()
        {
            ISquareService squareService = new SquareService();

            var circleSquare = squareService.GetSquare(5);
            Assert.Equal(78.53981633974483, circleSquare);
            Assert.Equal(78.53981633974483, squareService.GetSquare(new Circle(5)));

            var triagleSquare = squareService.GetSquare(3, 4, 5);
            Assert.Equal(6, triagleSquare);
            Assert.Equal(6, squareService.GetSquare(new Triangle(3, 4, 5)));
        }
    }
}
