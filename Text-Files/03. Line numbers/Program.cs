/*Description

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.*/

using System;
using System.IO;
using System.Text;

namespace _03.Line_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1="../../file1.txt";
            using (StreamReader reader = new StreamReader(file1,Encoding.UTF8))
            {
                try
                {
                    using (StreamWriter writer = File.CreateText("../../file2.txt"))
                    {
                        int index = 1;
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            writer.WriteLine("{0} . {1}", index, line);
                            index++;
                            line = reader.ReadLine();
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}
