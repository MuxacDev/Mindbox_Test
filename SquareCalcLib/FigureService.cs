using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public enum FigureType
    {
        Triangle,
        Circle
    }
    /// <summary>
    /// Сервис по созданию фигур
    /// </summary>
    public static class FigureService
    {
        //определение типа фигуры в момент выполнения
        public static IFigure CreateFigure(FigureType figureType, double[] parameters)
        {
            switch (figureType)
            {
                case FigureType.Circle:
                    return new Circle(parameters[0]);
                case FigureType.Triangle:
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    return null;
            }
        }
    }
}
