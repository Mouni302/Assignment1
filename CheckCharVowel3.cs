using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CheckCharVowel3
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a single character: ");
            char ch = Console.ReadKey().KeyChar; 
            Console.WriteLine();

            if( ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u'
                || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch =='U')
            {
                Console.WriteLine($"{ch} is a Vowel.");
            }
            else if (char.IsLetter(ch))
            {
                Console.WriteLine($"{ch} is a Consonant.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"{ch} is a Digit.");
            }
            else
            {
                Console.WriteLine($"{ch} is a Special Character.");
            }
            Console.Read();
        }
        
    }
}

    

