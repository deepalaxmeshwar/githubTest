using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345, sum = 0, b;
            while (a != 0)
            {
                b = a % 10;
                sum = sum + b;
                a = a / 10;
            }
            Console.WriteLine("the sum of the digits is:" + sum);
            Console.ReadLine();
        }
    }
}
