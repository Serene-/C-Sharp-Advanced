using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] st1 = { 1, 2, 3 };
            int[] st2 = st1;
            st2[0] = 10;
            Console.WriteLine(st1[0]);
            Console.WriteLine(st2[0]);
        }
    }
}
