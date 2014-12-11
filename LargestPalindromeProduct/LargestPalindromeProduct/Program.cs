using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "";
            int p = 0;
            for(int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {
                    string total = (i * j).ToString();
                    if (total == new string(total.Reverse().ToArray()))
                    {
                        if ((i*j) > p)
                        {
                            p = i * j;
                            palindrome = p.ToString();
                        }
                    }
                }
            }
            Console.WriteLine(palindrome);
            Console.ReadLine();
        }
    }
}

