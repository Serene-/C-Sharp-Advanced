/*Description

Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.*/

using System;
using System.IO;
using System.Text;

namespace _12.Remove_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "../../input.txt";
            string fileWords = "../../words.txt";
            string[] words=new string[20];
            StreamReader reader = new StreamReader(fileWords);
            using (reader)
            {
                try
                {
                    words = reader.ReadToEnd().Split(new string[]{System.Environment.NewLine},StringSplitOptions.RemoveEmptyEntries);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileLoadException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            StreamReader reader2 = new StreamReader(file);
            string fileContent=null;
            using (reader2)
            {
                try
                {
                    fileContent = reader2.ReadToEnd();
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileLoadException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }
            foreach(string word in words)
            {
                fileContent=fileContent.Replace(word, "");
            }
           Console.WriteLine(fileContent);
            StreamWriter writer = new StreamWriter(file, false);
            using (writer)
            {
                try
                {
                    writer.Write(fileContent);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileLoadException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IOException ex)
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
