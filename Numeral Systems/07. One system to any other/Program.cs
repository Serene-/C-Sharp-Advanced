/*
 * Description

Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.

Input

On the first line you will receive the number s
On the second line you will receive a number in base s - N
There will not be leading zeros
On the third line you will receive the number d
Output

Print N in base d
There should not be leading zeros
Use uppercase letters
 * Constraints

2 <= s, d <= 16
1 <= N <= 1018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static int FromAnyToDec(int s, string n)
        {
            int result = 0;
            n.ToUpper();
            int valueDigit;
            foreach (char digit in n)
            {
                if (char.IsDigit(digit))
                {
                    valueDigit = digit - '0';
                }
                else
                {
                    valueDigit = digit - 'A'+10;
                }
                result = result * s + valueDigit;
            }
            return result;
        }
        static string FromDecToAny(int dec, int d)
        {
            string result = "";
            string hexValues = "0123456789ABCDEF";
            int remainder=0;
            do
            {
                remainder = dec % d;
                if (remainder > 9) result = hexValues[remainder] + result;
                else result = remainder + result;
                dec = dec / d;
            }
            while (dec > 0);

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Base S=");
            int s = Int32.Parse(Console.ReadLine());
            Console.Write("Number N=");
            string n = Console.ReadLine();
            Console.Write("Converted to base D=");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FromDecToAny(FromAnyToDec(s, n), d));
        }
    }
}
