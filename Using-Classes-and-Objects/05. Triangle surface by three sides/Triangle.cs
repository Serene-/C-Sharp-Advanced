using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Triangle
    {
        private float a;
        private float b;
        private float c;
        private float p;//perimeter
        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            p = (a + b + c) / 2;
        }
        public double Surface()
        {
            double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return surface;
        }
    }
}
