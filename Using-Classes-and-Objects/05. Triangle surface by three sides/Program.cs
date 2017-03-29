/*
 * 
 * Description

Write program that calculates the surface of a triangle by given its three sides.

Input

On the first line you will receive the length of the first side of the triangle
On the second line you will receive the length of the second side of the triangle
On the third line you will receive the length of the third side of the triangle
Output

Print the surface of the rectangle with two digits of precision
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Triangle tr = new Triangle(a, b, c);
            Console.WriteLine("{0:.00}", tr.Surface());
        }
    }
}
