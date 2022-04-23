using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde {a} simvolu {b} simvolundan qabaq
            //ve o da {c} simvolundan qabaq gelirmi?
            string x = "cab";
            int a = x.IndexOf('a');
            int b = x.IndexOf('b');
            int c = x.IndexOf('c');
            if (x.Contains('a')==true && x.Contains('b')==true && x.Contains('b') == true)
            {
                if (a < b)
                {
                    if (b < c)
                    {
                        Console.WriteLine("Dogrudur");
                    }
                    else { Console.WriteLine("xeyr"); }
                }
                else
                {
                    Console.WriteLine("xeyr");
                }
            }
            else
            {
                Console.WriteLine(" herfler catmir");
            }
            
        }
    }
}
