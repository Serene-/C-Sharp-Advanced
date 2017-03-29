/*
 * Description

You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum. 
 * Write a program that reads a string of positive integers separated by spaces and prints their sum.

Input

On the only line you will receive a string consisted of positive integers
Output

Print the sum of the integers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_integers
{
    class Program
    {
        static int Sum(string numbers)
        {
            string[] num = numbers.Split(' ');
            int sum = 0;
            foreach (string n in num)
            {
                sum = sum + Int32.Parse(n);
            }
            return sum;

        }
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(Sum(numbers));
        }
    }
}
