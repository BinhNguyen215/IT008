using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1._1
{
    class Rectangle : Shape
    {
        public double height {  get; set; }
        public double width { get; set; }

        public Rectangle() { }
        public Rectangle(string name,string position,double height, double width) {
            this.name = name;
            this.position = position;
            this.height = height;
            this.width = width;
        }

        public override void draw()
        {
            Console.WriteLine($"Drawing a rectangle at position {position} with height {height} and width {width} ");
        }

        public override double area()
        {
            return height * width;
        }

        
    }
}
