using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde butun tek yerde dayanan simvollari
            //ondan sonra gelen simvolun BOYUK formasi ile evez et. 
            // salam  sLlMm

            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();




            for (int i = 0; i < str.Length - 1; i++)
            {

                if (i % 2 == 0)
                {
                }
                if (i % 2 == 1)
                {
                    str = str.Replace(str[i].ToString(), str[i + 1].ToString().ToUpper());


                }
            }
            Console.WriteLine(str);
        }
    }
}
