using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
               String letter = Console.ReadLine().ToLower();

                if (letter.Equals("a") || letter.Equals("e") || letter.Equals("i") || letter.Equals("o") || letter.Equals("u"))
                {
                    letter = Console.ReadLine();
                }

                else if (letter.Equals("!")) {
                    break;
                }

                else Console.WriteLine("Error");
            }
        }
    }
}
