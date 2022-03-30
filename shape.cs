namespace MyLib
{
    //абстрактный класс фигуры
    public abstract class Shape
    {
        //абстрактный метод для получения периметра
        public abstract double GetPerimetr();
        //абстрактный метод для получения площади
        public abstract double GetArea();
    }

    //производный класс прямогульника
    public class Rectangle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        //Переопределение получения периметра
        public override double GetPerimetr()
        {
            return Width * 2 + Height * 2;
        }

        //переопределение получения площади
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    //производный класс окружности
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // переопределение получения периметра
        public override double GetPerimetr()
        {
            return Radius * 2 * 3.14;
        }

        // переопределение получения площади
        public override double GetArea()
        {
            return Radius * Radius * 3.14;
        }
    }
}
