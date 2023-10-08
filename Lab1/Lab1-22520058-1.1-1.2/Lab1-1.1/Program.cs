namespace LAB1_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many shape do you want to create ?");
            int numShape = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < numShape; i++)
            {
                Console.WriteLine($"Shape: {i + 1}");
                Console.WriteLine("Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Position : ");
                string position = Console.ReadLine();

                Random random = new Random();
                int shapeType = random.Next(1, 4);

                switch (shapeType)
                {
                    case 1:
                        Console.WriteLine("Insert rectangle width: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert rectangle height: ");
                        double height = double.Parse(Console.ReadLine());
                        shapes.Add(new Rectangle(name, position, height, width));
                        break;
                    case 2:
                        Console.WriteLine("Insert triangle baselength : ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert triangle height : ");
                        double triHeight = double.Parse(Console.ReadLine());
                        shapes.Add(new Triangle(name,position, baseLength, triHeight));
                        break;
                    case 3:
                        Console.WriteLine("Insert circle radius : ");
                        double radius = double.Parse(Console.ReadLine());
                        shapes.Add(new Circle(name, position, radius));    
                        break;
                    case 4:
                        Console.WriteLine("Insert square sidelength : ");
                        double sideLength = double.Parse(Console.ReadLine());
                        shapes.Add(new Square(name, position, sideLength));
                        break;
                }
            }

            Console.WriteLine("Created shapes information : ");
            foreach (Shape shape in shapes)
            {
                shape.draw();
                Console.WriteLine($"Area of {shape.name} is {shape.area()}");
                Console.WriteLine();
            }
        }
    }
}