/*Description

Write a program that converts a decimal number N to its hexadecimal representation.

Input

On the only line you will receive a decimal number - N
There will not be leading zeros
Output

Print the hexadecimal representation of N on a single line
There should not be leading zeros
Use uppercase letter*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static string DecToHex(int number)
        {
            string result="";
            int value;
            string hexValues="0123456789ABCDEF";
            do
            {
                value=number % 16;
                result = hexValues[value] + result;
                number =number/16;
            }
            while (number>0);
            return result;
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DecToHex(n));
        }
    }
}
