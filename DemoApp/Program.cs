using SquareCalcLib;

namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---" + Environment.NewLine + "Треугольник" + Environment.NewLine + "---");
            try
            {
                Triangle triangle = FigureService.CreateFigure(FigureType.Triangle, new double[] { 2, 4, 5 }) as Triangle;
                Console.WriteLine($"Площадь треугольника: {triangle.Square}");
                string isRightAngled = triangle.IsRightAngled ? "ДА" : "НЕТ";
                Console.WriteLine($"Треугольник прямоугольный: {isRightAngled}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Triangle triangle = FigureService.CreateFigure(FigureType.Triangle, new double[] { 3, 4, 5 }) as Triangle;
                Console.WriteLine($"Площадь треугольника: {triangle.Square}");
                string isRightAngled = triangle.IsRightAngled ? "ДА" : "НЕТ";
                Console.WriteLine($"Треугольник прямоугольный: {isRightAngled}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---" + Environment.NewLine + "Круг" + Environment.NewLine + "---");
            try
            {
                Circle circle = FigureService.CreateFigure(FigureType.Circle, new double[] { 2 }) as Circle;
                Console.WriteLine($"Площадь круга: {circle.Square}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}