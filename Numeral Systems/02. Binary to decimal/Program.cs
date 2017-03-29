/*Description

Write a program that converts a binary number N to its decimal representation.

Input

On the only line you will receive a binary number - N
There will not be leading zeros*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static int BinToDec(string bin)
        {
            int dec = 0;
            bin.Reverse();
            int power=1;
            short temp;
            foreach(char bit in bin)
            {
                temp = Convert.ToInt16(bit);
                dec = temp * power + dec;
                power = power * 2;
            }
                return dec;
        }
        static void Main(string[] args)
        {
            string bin = Console.ReadLine();
        }
    }
}
