using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int nextdigit;
            int numdigit;
            int[] n = new int[20];
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number:" + num);
            Console.Write("number in worde:");
            nextdigit = 0;
            numdigit= 0;
            do
            {
                nextdigit = num % 10;
                n[numdigit] = nextdigit;
                numdigit++;
                num = num / 10;
            }
            while (num > 0);
            numdigit--;
            for (; numdigit >= 0; numdigit--)
                Console.Write(digits[n[numdigit]] + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
