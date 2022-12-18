using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfectnumbers
{
    class Program
    {
        static bool PerfectNum(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum = sum + i;
            }
            if (sum == number)
            { return true; };
            return false;
        }

        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Enter the first number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("\nPerfect numbers from " + n1 + " to " + n2 + " are: ");
            for (int i = n1; i <= n2; i++)
            {
                if (PerfectNum(i)) Console.Write("{0} , ", i);
            }

            Console.WriteLine("\n");
        }
    }
}