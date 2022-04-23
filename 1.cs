using System;

namespace Home_task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?
            string x = "Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?";
            if (x.Contains('a') == true && x.Contains('b') == true)
            {

                double Count = 0;
                foreach (char c in x)
                {
                    if (c == 'a')
                    {
                        Count++;
                    }
                }
                double k = Count;

                double Count2 = 0;
                foreach (char c in x)
                {
                    if (c == 'b')
                    {
                        Count2++;
                    }
                }
                double k2 = Count2;
                Console.WriteLine($"A-larin sayi {k}, b-lerin sayi {k2} , nisbet {k / k2}");
            }
            else
            {
                Console.WriteLine(" herfler catmir");
            }







        }
    }
}
