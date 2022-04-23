using System;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde en ilk ve en son {a} simvolundan bashqa
            //yerde qalan butun {a} simvollarini yox et. 
            //Verilmish metinde en ilk ve en son {a} simvolundan bashqa
            //yerde qalan butun {a} simvollarini yox et. 
            string x = "Aspaz Abbas as asmis, asmissa da az asmisa";
            char[] ch = x.ToCharArray();
            char a = 'a';

            int z = x.IndexOf(a);
            int y = x.LastIndexOf(a);

            string xdub = x.Remove(x.IndexOf(a), 1);

            xdub = x.Remove(x.LastIndexOf(a), 1);

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == a)
                {
                    if (x.IndexOf('a') == i)
                    {

                    }
                    if (ch[i] == a)
                    {
                        x = x.Replace(a, ' ');

                    }
                    if (x.LastIndexOf('a') == x.Length)
                    {

                    }

                }
            }
            Console.WriteLine(x);








        }
    }
}
