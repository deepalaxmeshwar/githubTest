using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("enter the number to check prime:");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("number is prime.");
            Console.ReadLine();


            

        }
    }
}
