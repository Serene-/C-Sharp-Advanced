/*Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt. 
 * The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods*/
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;


namespace _13.Count_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileWords = "../../words.txt";
            string file = "../../test.txt";
            string fileResult = "../../result.txt";

            string[] words; // words
            string fileContent; //the content of the test file
            int count=0;
            List<string> result=new List<string>();
            StreamReader reader = new StreamReader(fileWords);
            StreamReader reader2 = new StreamReader(file);
            string pattern; // pattern for The Regular Expression
            using(reader)
            using (reader2)
            {
                try
                {
                    words = reader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    fileContent = reader2.ReadToEnd();
                    foreach(string word in words)
                    {
                        pattern = string.Format(@"\b({0})\b",word);
                        foreach(Match m in Regex.Matches(fileContent,pattern,RegexOptions.IgnoreCase))
                        {
                            count++;
                        }
                        result.Add(count+" times - "+word);
                        count=0;
                    }
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
                    reader2.Close();
                }
            }
            result.Sort();
            result.Reverse();
            using (StreamWriter writer=new StreamWriter(fileResult,false))
            {
                foreach (string s in result)
                {
                    writer.WriteLine(s);
                }
               
            }

   

        }
    }
}
