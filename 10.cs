using System;
using System.Text.RegularExpressions;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Verilmish metinde butun reqemleri legv et. 
            string x = "Mehsulun qiymeti 10 manatdir";
            string y = RemoveDigits(x);
            Console.WriteLine(y);

        }
        public static string RemoveDigits(string key)
        {
            return Regex.Replace(key, @"\d", "");
        }
    }
    }

