using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Triangle
    {
        private float a;
        private float b;
        private double angle;
        public Triangle(float a, float b, double angle)
        {
            this.a = a;
            this.b = b;
            this.angle = angle;
        }
        public double Surface()
        {
            angle=(angle*Math.PI)/180; // converting from degrees to radians
            double surface = (a * b * Math.Sin(angle)) / 2;
            return surface;
        }
    }
}
