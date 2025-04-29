//Потрібно модифікувати код із основної лекції.
//Створити клас Shape, але зробити його абстрактним,
//та зробити похідні класи Circle, Rectangle, Square, та Triangle.
//Кожен метод має метод CalculateArea, що повертає площу конкретної фігури,
//в залежності від властивостей класу. Треба прописати формули розрахунку площі кожної фігури.
//Прямокутник Rectangle має поля Width та Height
//Круг Circle має поле Radius
//Трикутник Triangle має поле Width. Нехай за умовою трикутник завжди односторонній,
//а width — довжина однієї сторони.
//Квадрат Square має поле Width — довжина однієї сторони.

using System.Drawing;

namespace Basic_15_bonus_01_shape_area
{

    // Увага! Код класу Shape змінювати не потрібно! 

    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        // Тут мають бути якісь властивості
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            // Писати код тут
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        // Тут мають бути якісь властивості
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            // Писати код тут
            return Radius * Radius * 3.14;
        }
    }

    public class Triangle : Shape
    {
        // Тут мають бути якісь властивості
        public double Width;
        public double Height;

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            // Писати код тут
            return Width * Width / 2;
        }
    }

    public class Square : Shape
    {
        // Тут мають бути якісь властивості
        public double Width;

        public Square(double width)
        {
            Width = width;
        }

        public override double CalculateArea()
        {
            // Писати код тут
            return Width * Width;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(5, 10);
            Shape circle = new Circle(5);
            Shape triangle = new Triangle(4, 3);
            Shape square = new Square(4);

            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circle area: {circle.CalculateArea()}");
            Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
            Console.WriteLine($"Square area: {square.CalculateArea()}");
        }
    }
}
