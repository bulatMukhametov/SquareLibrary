using System;
using Xunit;

namespace SquareLibrary.Tests
{
    public class CircleTest
    {
        /// <summary>
        /// Тестирует некорректные значения радиуса
        /// </summary>
        [Fact]
        public void ArgumentsTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));

            var triangle = new Circle(3);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.Radius = -1);          
        }

        /// <summary>
        /// Тестирует вычисление площади
        /// </summary>
        [Fact]
        public void CircleGetSquareTest()
        {
            var circle = new Circle(5);

            var square = circle.GetSquare();

            Assert.Equal(78.53981633974483, square);
        }
    }
}
