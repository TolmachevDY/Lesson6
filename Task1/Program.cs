using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArrey = str.Split();
            string max = strArrey[0];
            foreach(string s in strArrey)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
