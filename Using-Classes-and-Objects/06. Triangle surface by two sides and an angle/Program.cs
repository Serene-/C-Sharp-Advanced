/*
 * Description

Write program that calculates the surface of a triangle by given two sides and an angle between them.

Input

On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the angle between the given sides
Angle is given in degrees
Output

Print the surface of the rectangle with two digits of precision
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            Triangle tr = new Triangle(a, b, angle);
            Console.WriteLine("{0:.00}",tr.Surface());
        }
    }
}
