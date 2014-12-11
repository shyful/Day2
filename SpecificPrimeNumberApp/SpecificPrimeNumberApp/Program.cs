using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificPrimeNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int k = 0;
            //int[] arr = new int[10004];
            for (int i = 2; i <=11; i++)
            {
                for (int j = 2; j <i; j++)
                {
                    if (i%j!=0)
                    {
                        Console.WriteLine(i); 
                        //break;
                        //arr[k] = i;

                        
                    }
                    
                    
                    //k++;

                }
                
            }
            //List<int> list = new List<int>(arr);
            //Console.WriteLine(arr[10000]);
        }
    }
}
