using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Verilmish metinde butun { a}
            //            simvollarinin qabagina { b}
            //            simvolunu ve
            //eyni zamandan butun { b}
            //            simvollarinin qabagina { a}
            //            simvolunu yaz. 
            string x = Console.ReadLine();
            char[] ch = x.ToCharArray();
            char a = 'a';
            char b = 'b';
            

            for (int i = 0; i < ch.Length-1; i++)
            {
                if (ch[i] == a)
                {
                    x = x.Insert(i, "b");
                    i++;
                }
                else if (ch[i]==b)
                {
                    x = x.Insert(i, "a");
                    i++;
                }


            }
           
            Console.WriteLine(x);


        }
    }
}
