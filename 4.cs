using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ?
            string a = "Aspaz Abbas as asmıs, asmissa da az asmis";
            char b = 'a';
            char[] ch = a.ToCharArray();
            int count = 0;
            if (a.Contains('a')==true)
            {
                if (ch[0] == b)
                {

                    count++;
                }
                if (count % 2 == 0)
                {
                    Console.WriteLine("CUT");
                }
                else
                {
                    Console.WriteLine("TEK");
                }
            }
            else
            {
                Console.WriteLine(" a yoxdur");
            }
           
        }
    }
}
