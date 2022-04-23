using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //15)* Verilmish metinde ilk ve son simvol eynidirse,
            //            ve metn daxilinde yanashi gelen { a}
            //            simvolu varsa,
            //ve metn daxilinde { b}
            //            simvolu yoxdursa
            //o zaman bu metnde butun { c}
            //            simvollari yox et ve
            //neticede alinan metn zerkalni olub olmadigini yoxla.
            string x = "caac";
            char[]y=x.ToCharArray();

            
           
            if (x.Contains('a')==true && x.Contains('b') == false && x.Contains('c') == true)
            {
                if (x[0]==y[0])
                {
                    for (int i = 0; i < x.Length-1; i++)
                    {
                        if (x[i] == 'a' && x[i + 1] == 'a')
                        {
                           x= Removec(x);

                        }
                        else
                        {
                            Console.WriteLine("yanasi a yoxdur");
                        }
                        if (x == x.ToCharArray().Reverse().ToString())
                        {
                            Console.WriteLine("guzgu eksidir");
                        }

                       
                    }
                }
                else
                {
                    Console.WriteLine("ilk ve son simvol eyni deyil");
                }
            }
            else
            {
                Console.WriteLine("emeliyyati heyata kecirmek ucun lazimi herfler yoxdur");
            }
            
           

        }
        public static string Removec(string key)
        {
            return Regex.Replace(key, "[c]", "");
        }
        

    }
}
