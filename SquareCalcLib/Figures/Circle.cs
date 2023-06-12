namespace SquareCalcLib
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double square;
        public double Square { get { return square; } }
        public Circle(double radius)
        {
            //валидация
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("радиус круга должен быть больше 0");
            }
            square = 3.14 * radius * radius;
        }
    }
}