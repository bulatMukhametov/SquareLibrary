using SquareLibrary.Figures.Base;
using System;

namespace SquareLibrary
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : AbstractFigure
    {
        private double _sideOne;
        private double _sideTwo;
        private double _sideThree;

        /// <summary>
        /// Cторона 1
        /// </summary>
        public double SideOne 
        { 
            get { return _sideOne; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть > 0");
                }
                _sideOne = value;
            } 
        }

        /// <summary>
        /// Cторона 2
        /// </summary>
        public double SideTwo
        {
            get { return _sideThree; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть > 0");
                }
                _sideThree = value;
            }
        }

        /// <summary>
        /// Cторона 3
        /// </summary>
        public double SideThree
        {
            get { return _sideTwo; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Сторона должна быть > 0");
                }
                _sideTwo = value;
            }
        }

        /// <summary>
        /// Прямоугольный
        /// </summary>
        public bool IsRight => IsRightTriangle();

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new ArgumentOutOfRangeException("Стороны должны быть > 0");
            }

            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }

        public override double GetSquare()
        {
            var semiPerimeter = (SideOne + SideTwo + SideThree) / 2;

            return Math
                .Sqrt(semiPerimeter * (semiPerimeter - SideOne) * (semiPerimeter - SideTwo) * (semiPerimeter - SideThree));
        }

        private bool IsRightTriangle()
        {
            return Math.Pow(SideOne, 2) == Math.Pow(SideTwo, 2) + Math.Pow(SideThree, 2) 
                || Math.Pow(SideTwo, 2) == Math.Pow(SideOne, 2) + Math.Pow(SideThree, 2)
                || Math.Pow(SideThree, 2) == Math.Pow(SideOne, 2) + Math.Pow(SideTwo, 2);
        }
    }
}
