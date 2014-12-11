using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;
            for (int i = 2; i <= 1000; i++)
            {
                if (13195%i==0)
                {
                    for (int j = 2; j < 10; j++)
                    {
                        if (i%j==0)
                        {
                            break;
                            
                        }
                    }
                    if (largest<i)
                    {
                        largest = i;
                    }
                }
               
            }
            Console.WriteLine(largest);
            Console.ReadLine();
        }
    }
}
