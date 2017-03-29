/*Write a program that converts a decimal number N to its binary representation.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static string DecToBin(int n)
        {
            StringBuilder bin = new StringBuilder();
            int remainder=default(int);
            do
            {
                remainder = n % 2;
                bin.Insert(0, remainder);
                n = n / 2;

            } while (n > 0);
            return bin.ToString();
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(n));
        }
    }
}
