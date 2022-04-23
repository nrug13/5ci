using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden tek yerde dayanan simvollarin
            //hamisi {a} simvoludurmu?
            string a = "Aspaz Abbas as asmıs, asmissa da az asmis";
            char b = 'a';
            char[] ch = a.ToCharArray();
            int count = 0;
            int count2= 0;
            if (a.Contains('a') == true)
            {
                for (int i = 0; i < ch.Length - 1; i++)
                {
                    if (i % 2 == 1)
                    {
                        count2++;
                        if (ch[i] == b)
                        {
                            Console.WriteLine($"{i} : {ch[i]}");
                            count++;
                        }
                        if (ch[i] != b)
                        {
                            Console.WriteLine($"{i} a deyil");
                        }


                    }
                }
                if (count == count2)
                {
                    Console.WriteLine("beli");

                }
                else
                {
                    Console.WriteLine("xeyr");
                }

            }
            else
            {
                Console.WriteLine("a yoxdur");
            }
                
        }
    }
}
