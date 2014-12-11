using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int sum = 0;
            int a = 0;
            //Console.WriteLine("{0}", a);
            int b = 1;
            //Console.WriteLine("{0}", b);
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                //Console.WriteLine("{0}", c);
                a = b;
                b = c;
                if (c%2==0)
                {
                    sum = sum + c;
                    
                    //Console.WriteLine("{0}", c);
                }


            }
            Console.WriteLine("{0}", sum);
        }
    }

}
