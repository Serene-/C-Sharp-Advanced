/*
 * Description

Write program that calculates the surface of a triangle by given a side and an altitude to it.

Input

On the first line you will receive the length of a side of the triangle
On the second line you will receive the altitude to that side
Output

Print the surface of the rectangle with two digits of precision
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float Ha = float.Parse(Console.ReadLine());
            Triangle tr = new Triangle(a, Ha);
            Console.WriteLine("{0:.00}",tr.Surface());
        }

    }
}
