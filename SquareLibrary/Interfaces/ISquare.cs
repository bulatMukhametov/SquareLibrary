using SquareLibrary.Figures.Base;
using System;
namespace SquareLibrary.Interfaces
{
    interface ISquare
    {
        double GetSquare(AbstractFigure figure);
        double GetSquare(double radius);
        double GetSquare(double x, double y, double z);       
    }
}
