using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string s = System.Console.ReadLine();
            char[] s1 = s.ToCharArray();
            IEnumerable<char> s2 = s1.Distinct();
            Console.WriteLine("Количество различных букв в слове равно: {0}", s2.Count());
            Console.ReadKey();
        }
    }
}
