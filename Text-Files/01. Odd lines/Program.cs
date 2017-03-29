
/*Description

Write a program that reads a text file and prints on the console its odd lines.*/
using System;
using System.IO;
using System.Text;

namespace _01.Odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../sample.txt";
            Encoding encoding = Encoding.UTF8;
            StreamReader reader = new StreamReader(fileName, encoding);
            Console.OutputEncoding=encoding;
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
                line = reader.ReadLine();
            }
            reader.Close();

        }
    }
}
