using SquareLibrary.Figures.Base;

namespace SquareLibrary.Interfaces
{
    public interface ISquareService
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="figure">Фигура</param>
        /// <returns>Площадь</returns>
        double GetSquare(AbstractFigure figure);
        
        /// <summary>
        /// Получить площадь круга по радиусу
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns>Площадь</returns>
        double GetSquare(double radius);

        /// <summary>
        /// Получить треугольника по трем сторонам
        /// </summary>
        /// <param name="sideOne">Сторона 1</param>
        /// <param name="sideTwo">Сторона 2</param>
        /// <param name="sideThree">Сторона 3</param>
        /// <returns>Площадь</returns>
        double GetSquare(double sideOne, double sideTwo, double sideThree);       
    }
}
