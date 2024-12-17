using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SumofNumbers5
    {

        static void Main(string[] args)
        {
            int sum = 0;
            for (int i=1; i<=10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Sum of 10 Numbers :" + sum);
        }
    }
}
