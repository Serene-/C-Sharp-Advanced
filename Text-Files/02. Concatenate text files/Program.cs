/*Concatenate text files

Description

Write a program that concatenates two text files into another text file.*/
using System;
using System.IO;
using System.Text;


namespace _02.Concatenate_text_files
{
    class Program
    {
        static void Main(string[] args)
        {
           string file1=File.ReadAllText("../../file1.txt");
           string file2 = File.ReadAllText("../../file2.txt");
            using(StreamWriter writer=File.CreateText("../../file3.txt"))
            {
                try
                {
                    writer.Write(file1);
                    writer.Write(file2);
                }
                finally
                {
                    writer.Close();
                }
                
            }

        }
    }
}
