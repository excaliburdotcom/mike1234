using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,str_output;
            Console.Write("Enter a string: ");
            str = Console.ReadLine().ToLower();
       for(int x = 0; x < str.Length; x++)
            {
                str_output = str[x].ToString()=="a" ? "Vowel" :
                    str[x].ToString().ToLower() == "e" ? "Vowel" :
                    str[x].ToString() == "i" ? "Vowel" :
                    str[x].ToString() == "o" ? "Vowel" :
                    str[x].ToString() == "u" ? "Vowel" :
                    "Consonant";
                Console.WriteLine($"{str[x]} {str_output}");
            }
    
            Console.ReadKey();
        }
    }
}
