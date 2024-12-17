using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Prime4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int cnt = 0;

            if (number <= 1)
            {
                cnt = 0; 
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        cnt = cnt+1;
                    }
                }
            }

            if (cnt>2)
            {
                Console.WriteLine($"{number} is not a Prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is a Prime number.");
            }
            Console.Read();
        }
    }
}
