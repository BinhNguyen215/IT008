using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1._1
{
    class Circle : Shape
    {
        public double radius {  get; set; }

        public Circle() { }

        public Circle(string name, string position, double radius) {
            this.name = name;
            this.position = position;
            this.radius = radius;
        }

        public override void draw()
        {
            Console.WriteLine($"Drawing a circle at position {position} with radius {radius}");
        }

        public override double area()
        {
            return Math.Pow(radius,2)*Math.PI;
        }

        
    }
}
