using SquareLibrary.Figures.Base;
using SquareLibrary.Interfaces;

namespace SquareLibrary.Impl
{
    public class SquareService : ISquareService
    {
        public double GetSquare(double radius)
        {
            var circle = new Circle(radius);
            return circle.GetSquare();
        }

        public double GetSquare(double sideOne, double sideTwo, double sideThree)
        {
            var triangle = new Triangle(sideOne, sideTwo, sideThree);
            return triangle.GetSquare();
        }

        public double GetSquare(AbstractFigure figure)
        {
            return figure.GetSquare();
        }
    }
}
