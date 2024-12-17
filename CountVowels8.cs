using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CountVowels8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The name: ");
            string name = Console.ReadLine();

            int count = 0;

            foreach (char c in name)
            {
                if (c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' 
                   || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U')
                {
                    count++;
                }
            }

            Console.WriteLine($"The number of vowels in the name: {count}");
        }
    }
}
