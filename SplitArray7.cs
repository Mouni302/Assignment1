using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SplitArray7
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the string");
            string name = Console.ReadLine();
            string[] nameArray = name.Split(' ');

            foreach (string item in nameArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
