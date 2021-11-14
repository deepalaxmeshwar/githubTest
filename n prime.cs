using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, p, k;
            Console.Write("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= n; i++)
            {
                k = 2;
                p = 1;
                while (k < i)
                {
                    if (i % k == 0)
                    {
                        p = 0;
                        break;
                    }
                    k++;
                }
                if (p == 1)
                {
                    Console.WriteLine("number is prime:" + i);
                    Console.ReadLine();
                }
            }
        }
    }
}
    
