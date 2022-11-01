using System;
using Xunit;

namespace SquareLibrary.Tests
{
    public class TriangleTest
    {
        /// <summary>
        /// ��������� ������������ �������� ������
        /// </summary>
        [Fact]
        public void ArgumentsTest()
        {                       
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 2));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 0));

            var triangle = new Triangle(3, 4, 5);

            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.SideOne = 0);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.SideTwo = -1);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.SideThree = -100);
        }

        /// <summary>
        /// ��������� ���������� �������
        /// </summary>
        [Fact]
        public void TriangleGetSquareTest()
        {
            var triangle = new Triangle(3, 4, 5);

            var square = triangle.GetSquare();  

            Assert.Equal(6, square);
        }

        /// <summary>
        /// ��������� ������������ ����������� ���������������
        /// </summary>
        [Fact]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRight);
        }

        /// <summary>
        /// ��������� ������������ ����������� ���������������
        /// </summary>
        [Fact]
        public void TriangleIsNotRightTest()
        {
            var triangle = new Triangle(3, 4, 6);

            Assert.False(triangle.IsRight);
        }
    }
}
