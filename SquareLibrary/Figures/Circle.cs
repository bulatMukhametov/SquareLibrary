using SquareLibrary.Figures.Base;
using System;

namespace SquareLibrary
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : AbstractFigure
    {
        private double _radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { 
            get { return _radius; } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Радиус должен быть > 0");
                }
                _radius = value; 
            } 
        }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть > 0");
            }

            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);   
        }
    }
}
