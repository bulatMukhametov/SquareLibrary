using SquareLibrary.Figures.Base;

namespace SquareLibrary.Interfaces
{
    public class Square : ISquare
    {
        public double GetSquare(double radius)
        {
            var circle = new Circle(radius);
            return circle.GetSquare();
        }

        public double GetSquare(double x, double y, double z)
        {
            var triangle = new Triangle(x, y, z);
            return triangle.GetSquare();
        }

        public double GetSquare(AbstractFigure figure)
        {
            return figure.GetSquare();
        }
    }
}
