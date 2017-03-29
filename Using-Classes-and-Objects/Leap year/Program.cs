/*Description

Write a program that reads a year from the console and checks whether it is a leap one.

Hint: Use System.DateTime.

Input

On the only line you will receive a number - the year
Output

Print "Leap" or "Common" on a single line depending on the year*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number = Int16.Parse(Console.ReadLine());
            LeapYear year = new LeapYear(number);
            Console.WriteLine(year.IsLeapYear());
        }
    }
}
