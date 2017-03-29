/*Description

Write a program to convert hexadecimal numbers to binary numbers (directly).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static string HexToBinary(string hex)
        {
            string[] binaryValues ={   "0000",
                                      "0001",
                                      "0010",
                                      "0011",
                                      "0100",
                                      "0101",
                                      "0110",
                                      "0111",
                                      "1000",
                                      "1001",
                                      "1010",
                                      "1011",
                                      "1100",
                                      "1101",
                                      "1110",
                                      "1111",
                                  };
            string result = "";
            foreach(char digit in hex)
            {
                int digitValue=0;
                if(char.IsDigit(digit)) 
                {
                    digitValue=digit-'0';
                }
                else
                {
                    digitValue=digit-'A'+10;
                }
                result=result+binaryValues[digitValue];
            }
            result=result.TrimStart('0');
            return result;
        }
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.WriteLine(HexToBinary(n));
        }
    }
}
