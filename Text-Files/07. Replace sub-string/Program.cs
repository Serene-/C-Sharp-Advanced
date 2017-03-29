/*Description

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file. Ensure it will work with large files (e.g. 100 MB).*/
using System;
using System.Text;
using System.IO;


namespace _07.Replace_sub_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../input.txt";
            StringBuilder content=new StringBuilder();
            StreamReader reader = new StreamReader(fileName);
            using(reader)
            {
                try
                {
                content.Append(reader.ReadToEnd());
                content.Replace("start","finish");

                }
                catch(FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                { 
                    reader.Close();
                }

            }
            StreamWriter writer = new StreamWriter(fileName, false);
            using (writer)
            {
                try
                {
                    writer.Write(content);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    writer.Close();
                }
            }

            
        }
    }
}
