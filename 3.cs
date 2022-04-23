using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir.
           
            string a = "Aspaz Abbas as asmıs, asmissa da az asmis";
            char b = 'b';
            char[] ch = a.ToCharArray();
            int count = 0;
            if (a.Contains('b')==true)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i % 2 == 1)
                    {
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
                Console.WriteLine($"{count} denesi b-dir");
            }
            else
            {
                Console.WriteLine("b yoxdur");
            }
            
        }
    }
}
