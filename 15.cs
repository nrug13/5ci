using System;
using System.Text.RegularExpressions;

namespace _7
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
            string x = "bac";
            char[] y = x.ToCharArray();
            int n = x.Length;


            if (x.Contains('a') == true && x.Contains('b') != true && x.Contains('c') == true)
            {
                  char[] q1 = x.ToCharArray();
                    int flag = 0;
                    for (int i = 0; i <= n / 2 && n != 0; i++)
                    {

                        if (x[i] != x[n - i - 1]&& (x[i]=='a'&& x[i+1]=='a'))
                        {
                            flag = 1;
                            break;

                        }
                        else
                        {
                        Removec(x);
                        
                        }
                    }
                Console.WriteLine($"sertler odendi");
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

    } }
  
