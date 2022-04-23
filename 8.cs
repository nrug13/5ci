using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde ilk qabagima cixan {a}
            //simvolundan sonra gelen simvolu 10 defe dalbadal cap et.
            string x = "Bazarda ne ucuz? Mis ucuz, duz ucuz, kuncut ucuz";
            char[] x1 = x.ToCharArray();
            char a = 'a';
            int count = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x1[i] == 'a')
                {
                    count++;
                    if (count == 1)
                    {
                        int z = i + 1;
                        string result = new String(x1[z], 10);
                        Console.WriteLine(result);

                    }
                }
            }
        }
    }
}
