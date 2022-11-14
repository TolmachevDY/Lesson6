using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = str.ToLower();
            string str2 = str1.Replace(" ","");
            string str3 = "";
            foreach (char c in str2)
            {
                str3 = c + str3;
            }
            if (str2==str3)
            {
                Console.WriteLine("строка является палиндромом");
            }
            else
            {
                Console.WriteLine("строка не является палиндромом");
            }           
            Console.ReadKey();
        }
    }
}
