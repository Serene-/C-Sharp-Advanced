/*
 * Description

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */
using System;
using System.Collections;
using System.Collections.Specialized;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static string BinaryToHex(string binary)
        {
            string result = string.Empty;
            string hexValues = "0123456789ABCDEF";
            int leng=binary.Length%4;
            leng = 4 - leng;
            if(leng!=0 && leng!=4)
            {
                for (int i = 0; i < leng; i++)
                {
                    binary = binary.Insert(0, "0");
                }
            }
            int index = 0;
            string tempValue;
            do
            {
                tempValue = binary.Substring(index, 4);
                index = index + 4;
                int tempResult=0;
                foreach (char digit in tempValue)
                {
                    tempResult = tempResult * 2 + digit - '0';

                }
                result = result + hexValues[tempResult];
            }
            while (index <= binary.Length-4);
            return result;
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine("result in HEX: {0}",BinaryToHex(n));

        }
    }
}
