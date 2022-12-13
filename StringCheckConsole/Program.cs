using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCheckLibrary;

namespace StringCheckConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи слово");
            string a = Console.ReadLine();
            List<char> actual = StringCheckClass.GetLetters(a);
            for(int i = 0; i < actual.Count; i++)
            {
                Console.WriteLine(actual[i]);
            }
            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}
