/*Description

Write a program that deletes from given text file all odd lines. The result should be in the same file.
 */

using System;
using System.IO;
using System.Text;

namespace _09.Delete_odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../text.txt";
            StringBuilder text=new StringBuilder();
            int index = 1;
            StreamReader reader = new StreamReader(fileName);
            string line;
            using (reader)
            {
                line = reader.ReadLine();
                do
                {
                    if (index % 2 ==0)
                    {
                        text.AppendLine(line);
                    }
                    index++;
                    line = reader.ReadLine();
                } while (line != null);
            }
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(text);
            }
        }
    }
}
