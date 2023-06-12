using SquareCalcLib;

namespace TestProject
{
    public class SquareCalcLibTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5.2)]
        public void IsCorrectCircleSquare_DoubleValues_ReturnTrue(double r)
        {
            var result = FigureService.CreateFigure(FigureType.Circle, new double[] { r }).Square;

            Assert.True(3.14 * r * r == result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 4, 5)]
        [InlineData(1.1, 2.2, 3.3)]
        public void IsCorrectTriangleSquare_DoubleValues_ReturnTrue(double a, double b, double c)
        {
            var result = FigureService.CreateFigure(FigureType.Triangle, new double[] { a, b, c }).Square;

            double p = 0.5 * (a + b + c);
            Assert.True(Math.Sqrt(p * (p - a) * (p - b) * (p - c)) == result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(3, 4, 5)]
        [InlineData(1.1, 2.2, 3.3)]
        public void IsRightAngledTriangle_DoubleValues_ReturnTrue(double a, double b, double c)
        {
            var result = (FigureService.CreateFigure(FigureType.Triangle, new double[] { a, b, c }) as Triangle).IsRightAngled;


            Assert.True(true == result, "Треугольник не является прямоугольным - Верный результат");
        }

    }


}