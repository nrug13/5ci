using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilimish metinde butun simvollari ardicil shekilde
            //biri balaca, biri boyuk formada cap et. 
            char[] ch = new string(Console.ReadLine()).ToCharArray();

            string result = new string(ch);

            

            for (int i = 0; i < ch.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ch[i]=char.ToLower(ch[i]);

                }
                if (i % 2 == 1)
                {
                    ch[i] = char.ToUpper(ch[i]);
                    


                }
                
            }
            Console.WriteLine(ch);
        }
    }
}
