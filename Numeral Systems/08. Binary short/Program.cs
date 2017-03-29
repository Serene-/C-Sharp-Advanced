/*
 * Binary short

Description

Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

Input

On the only line you will receive a decimal number - N
Output

Print the its binary representation on a single line
There should be exactly 16 digits of output
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_short
{
    class Program
    {
        static string ShortToBinary(int number)
        {
            string result="";
            int remainder;
            if (number >= 0)
            {
                do
                {
                    remainder = number % 2;
                    number = number / 2;
                    result = remainder + result;
                } while (number > 0);
                while (result.Length < 16)
                {
                    result = '0' + result;
                };
            }
            else
            {
                number = Math.Abs(number) - 1;
                do
                {
                    remainder = number % 2;
                    number = number / 2;
                    if (remainder == 1)
                    {
                        result = '0' + result;
                    }
                    else
                    {
                        result = '1'+ result;
                    }
                } while (number > 0);
                while (result.Length < 16)
                {
                    result = '1' + result;
                };
            }
            return result;
        }
        static void Main(string[] args)
        {
            short number = Int16.Parse(Console.ReadLine());
            Console.WriteLine(ShortToBinary(number));
        }
    }
}
