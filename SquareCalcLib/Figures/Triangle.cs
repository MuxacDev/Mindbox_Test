namespace SquareCalcLib
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private readonly double square;
        private readonly bool isRightAngled;
        public double Square { get { return square; } }
        public bool IsRightAngled { get { return isRightAngled; } }
        public Triangle(double sideA, double sideB, double sideC)
        {
            //валидация
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("стороны треугольника должны быть больше 0");
            }
            double perimeter = 0.5 * (sideA + sideB + sideC);
            square = Math.Sqrt(
                perimeter *
                (perimeter - sideA) *
                (perimeter - sideB) *
                (perimeter - sideC)
                );
            //Проверка на прямоугольность
            isRightAngled =
                sideA * sideA == sideB * sideB + sideC * sideC ||
                sideB * sideB == sideA * sideA + sideC * sideC ||
                sideC * sideC == sideA * sideA + sideB * sideB;
        }
    }
}