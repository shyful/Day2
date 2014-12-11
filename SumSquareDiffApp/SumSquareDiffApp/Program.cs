using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDiffApp
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum=0;
            long sumsquare = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i*i;
            }
            for (int j = 1; j < 100; j++)
            {
                sumsquare = sumsquare + j;
            }
            Console.WriteLine(Math.Pow(sumsquare,2)-sum);
        }
    }
}
