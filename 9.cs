using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            string x = "Bazarda ne ucuz? Mis ucuz, duz ucuz, kuncut ucuz";
            string a = x.Substring(0, 3);
            string b = x.Substring(x.Length - 3, 3);
            string b2 = Reverse(b);



            if (b2 == a)
            {
                Console.WriteLine("beli");
            }
            else
            {
                Console.WriteLine("xeyr");
            }


        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    }

