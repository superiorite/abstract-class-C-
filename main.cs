using MyLib;

var rectagnle = new Rectangle { Width = 20, Height = 20 };
var circle = new Circle { Radius = 200 };

PrintShape(rectagnle); // Perimetr: 80 Area: 400
PrintShape(circle);    // Perimetr: 1256 Area: 125600


void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimetr: {shape.GetPerimetr()} Area: {shape.GetArea()}");
}
