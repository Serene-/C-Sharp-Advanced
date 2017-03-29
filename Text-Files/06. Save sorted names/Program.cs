/*Description

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

Example:

input.txt	
Ivan 
Peter 
Maria 
George	
 * 
output.txt
George 
Ivan 
Maria 
Peter*/
using System;
using System.Collections.Generic;
using System.IO;

namespace _06.Save_sorted_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "../../input.txt";
            string outputFile = "../../output.txt";
            List<string> list = new List<string>();
            StreamReader reader = new StreamReader(inputFile);
            string line;
            using(reader)
            {
                line = reader.ReadLine();
                list.Add(line);
                while (line != null)
                    {
                        line = reader.ReadLine();
                        if(line!=null)  list.Add(line);
                    }
            }
            list.Sort();
            StreamWriter writer = new StreamWriter(outputFile);
            using (writer)
            {
                foreach (string item in list)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
