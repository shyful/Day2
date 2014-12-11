using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //long Count=1;
            bool divisibleby20 = false;
            long number = 21;
            while (true)
            {
                number++;
                for (int i = 1; i <= 20; i++)
                {
                    if (number%i == 0)
                    {
                        divisibleby20 = true;
                    }
                    else
                    {
                        divisibleby20 = false;
                        break;
                    }


                }
                if (divisibleby20)
                {
                    Console.WriteLine("{0}", number);
                    break;
                }
            }
            

        }
    }
}

