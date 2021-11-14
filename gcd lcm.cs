using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        public static void Main()
        {
            long num1, num2, hcf, lcm;
            Console.WriteLine("find the gcd and lcm of two numbers");
            Console.WriteLine("..........");
            Console.Write("input the first number:");
            num1 = Convert.ToInt64(Console.ReadLine());
            Console.Write("input the second number:");
            num2 = Convert.ToInt64(Console.ReadLine());
            hcf = gcd(num1, num2);
            lcm = (num1 * num2) / hcf;
            Console.WriteLine("\nthe gcd of {0} and {1}={2}", num1, num2, hcf);
            Console.WriteLine("\nthe lcmof {0} and {1}={2}\n", num1, num2, hcf);

        }
        static long gcd(long n1, long n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                return gcd(n2, n1 % n2);

            }
        }
    }
}
    
