using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] MasChar = { 'H', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '!' };
            Console.WriteLine(MasChar);
            StringBuilder StrB = new StringBuilder();
            foreach (char i in MasChar)
            {
                StrB.Append(i);
                Console.WriteLine(StrB);
            }
            StrB.Replace('!', '?');
            Console.WriteLine(StrB);
            StrB.Remove(5, 7);
            Console.WriteLine(StrB);
            StrB.Insert(5, " Visual Studio!");
            Console.WriteLine(StrB);
            Console.ReadKey();
        }
    }
}
