/*
 * Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
 * Assume the files have equal number of lines.
 */
using System;
using System.Text;
using System.IO;

namespace _04.Compare_text_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName1="../../file1.txt";
            string fileName2 = "../../file2.txt";
            int sameLines = 0; //The number of lines that are the same
            int diffLines = 0; //The number of lines that are different
            StreamReader reader1 = new StreamReader(fileName1, System.Text.Encoding.UTF8);
            StreamReader reader2 = new StreamReader(fileName2, System.Text.Encoding.UTF8);
            string line1 = reader1.ReadLine();
            string line2=reader2.ReadLine();
            using(reader1)
            {
                using (reader2)
                {
                    while (line1 != null)
                    {
                        if (line1.CompareTo(line2)==0) sameLines++;
                        else diffLines++;
                        line1 = reader1.ReadLine();
                        line2 = reader2.ReadLine();
                    }

                }
            }
            Console.WriteLine("The lines that are the same are {0}", sameLines);
            Console.WriteLine("The lines that are different are {0}", diffLines);

        }
    }
}
