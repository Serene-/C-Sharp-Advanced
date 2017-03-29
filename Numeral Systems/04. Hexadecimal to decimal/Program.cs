/* Hexadecimal to decimal

Description

Write a program that converts a hexadecimal number N to its decimal representation.

Input

On the only line you will receive a hexadecimal number - N
There will not be leading zeros
Letters will be uppercase
Output

Print the decimal representation of N on a single line
There should not be leading zeros
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static int HexToDec(string hex)
        {
            int result=0;
            hex.ToUpper();
            foreach (char digit in hex)
            {
                if (char.IsDigit(digit))
                {
                    result =result*16+ digit-'0';
                }
                else
                {
                    result= result * 16+(digit - 'A' + 10) ;
                }

            }

            return result;
        }
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(HexToDec(hex));
        }
    }
}
