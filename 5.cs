using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?
            string x = "cccb aac dba";
            int a = x.IndexOf('a');
            int b = x.IndexOf('b');
            int c = x.IndexOf('c');
            if (x.Contains('a') == true && x.Contains('b') == true && x.Contains('b') == true)
            {
                if (a <= b && a <= c)
                {
                    Console.WriteLine("\n Ilk gelen:a");
                }

                if (b <= a && b <= c)
                {
                    Console.WriteLine("\n Ilk gelen:b");
                }

                if (c <= a && c <= b)
                {
                    Console.WriteLine("\n Ilk gelen:c");
                }
            }
            else
            {
                Console.WriteLine("herfler catmir");
            }

               
        }
    }
}
