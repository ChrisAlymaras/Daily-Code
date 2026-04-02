namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            
            shapes.Add(circle);
            shapes.Add(rectangle);

            Console.WriteLine("Shape\tPerimeter\tArea");
            string type;
            foreach(var shape in shapes)
            {
                if (shape.GetType() == typeof(Circle))
                    type = "Circle";
                else
                    type = "Rectan";
                Console.WriteLine($"{type}\t{shape.GetPerimeter()}\t\t{shape.GetArea()}");
            }

        }
    }
}
