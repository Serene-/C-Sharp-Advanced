/*Description

Write a program that reads a text file containing a square matrix of numbers. Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.

The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 */


using System;
using System.Text;
using System.IO;

namespace _05.Maximal_area_sum
{
    class Program
    {
        static int MaxSum(int[,] array,int area)
        {
            int maxSum = 0;
            int sum;
            for (int i = 0; i <= array.GetLength(0) - area; i++)
            {
                for (int j = 0; j <= array.GetLength(1) - area; j++)
                {
                    sum = array[i, j] + array[i, j + 1] + array[i+1, j] + array[i + 1, j + 1];
                    if (maxSum < sum) maxSum = sum;
                }
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            string fileName = "../../input.txt";
            int[,] matrix;
            int n;
            StreamReader reader = new StreamReader(fileName);
            string[] temp;// saving the rows of the matrix
            using (reader)
            {
                n = int.Parse(reader.ReadLine());
                matrix=new int[n,n];
                for (int i = 0; i < n; i++)
                {
                    temp=reader.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(temp[j]);

                    }
                }
            }
            StreamWriter writer = new StreamWriter("../../output.txt", false);
            using (writer)
            {
                writer.Write(MaxSum(matrix,2));
            }

        }
    }
}
