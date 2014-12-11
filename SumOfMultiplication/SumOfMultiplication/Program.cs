using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <=9; i++)
            {
                if (i%3==0||i%5==0)
                {
                    sum = sum + i;
                   
                }

            } 
            Console.WriteLine("{0}", sum);
        }
    }
}
