using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        { //Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
            string x = "Bazarda ne ucuz? Mis ucuz, duz ucuz, kuncut ucuz";
            int a = x.IndexOf('a');
            string y = Reverse(x);
            int b = y.IndexOf('a');
            if (x.Contains('a')==true)
            {
                if (a == b)
                {
                    Console.WriteLine("eynidir");
                }
                else
                {
                    Console.WriteLine("deyil");
                }
            }
            else
            {
                Console.WriteLine("a herfi yoxdur");
            }
            


        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

