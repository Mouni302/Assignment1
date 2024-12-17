using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MaxNumber6
    {
        static void Main(string[] args)
        {
            int Maximum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number = int.Parse(Console.ReadLine());
                if (number > Maximum) {
                    Maximum = number;
                }
            }
            Console.WriteLine("Maximum of 10 numbers:" +Maximum);
        }
    }
}
