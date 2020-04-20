using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long[] array = new long[10000000];

            long n = 1;
            int i = 5;
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 5;
            array[4] = 7;
            while (n < 10000000 - 1)
            {
              if(n % 2 != 0 && n % 3 !=0 && n % 5 != 0 && n % 7 != 0)
                {
                    array[i] = n;
                    i++;
                }
                n++;
            }

            Console.WriteLine("Prime numbers:");
            for (int m = 0; m < array.Count(); m++)
            {
                Console.Write(" {0},", array[m]);
                if(array[m] % 30 == 0)
                {
                    Console.Write("\n");
                }
            }


            Console.ReadKey();
        }
    }
}
