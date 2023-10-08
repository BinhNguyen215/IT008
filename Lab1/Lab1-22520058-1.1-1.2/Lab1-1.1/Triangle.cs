using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1._1
{
    class Triangle : Shape
    {
        public double baseLength { get; set; }
        public double height { get; set; }

        public Triangle() { }

        public Triangle(string name,string position, double baseLength, double height)
        {
            this.name = name;
            this.position = position;
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double area()
        {
            return 0.5 * baseLength * height;
            
        }

        public override void draw()
        {
            Console.WriteLine($"Drawing a triangle at position {position} with baselength {baseLength} and height {height}");
            
        }

        
    }
}
