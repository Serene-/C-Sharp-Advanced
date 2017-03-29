/*
 * Prefix "test"

Description

Write a program that deletes from a text file all words that start with the prefix test. Words contain only the symbols 0…9, a…z, A…Z, _.
*/

using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.Prefix_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../input.txt";
            StreamReader reader = new StreamReader(fileName);
            string allText = null;
            using (reader)
            {
               string line = reader.ReadLine();

                while (line != null)
                {
                    allText=allText+Regex.Replace(line, @"\btest\w{1,}", " ");
                    line = reader.ReadLine();
                }
            }
            //Console.WriteLine(allText);
            StreamWriter writer = new StreamWriter(fileName, false);
            using (writer)
            {
                writer.Write(allText);
            }

        }
    }
}
