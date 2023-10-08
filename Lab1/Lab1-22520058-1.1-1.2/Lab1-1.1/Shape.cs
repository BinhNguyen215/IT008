using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1._1
{
    public abstract class Shape
    {
        public string name { get; set; }
        public string position { get; set; }

        public abstract void draw();

        public abstract double area();

    }
}
