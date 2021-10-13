using System;
using System.Linq;
using System.Globalization; // Kapital huruf pertama tiap kata
using System.Text;

namespace TesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountOccurance();
            //UppercaseFirstChar();
            ToUpperFirst();
        }

        // Hitung jumlah huruf dalam kalimat
        public static void CountOccurance()
        {
            string str = "aaabbcccaaaac";
            Console.WriteLine("String = "+ str);

            while (str.Length > 0)
            {
                
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(str[0] + " = " + cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }

        // Kapital huruf pertama tiap kata
        public static void UppercaseFirstChar()
        {
            string str = "CAPITALIZE FIRST CHARACTER FROM ALL CAPS";
            string str2 = "cAPItAlizE first chARAcTer FrOM RaNDom";
            Console.WriteLine("String 1 = " + str);
            Console.WriteLine("String 2 = " + str2);

            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
            str2 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str2.ToLower());
            Console.WriteLine("String 1 Title = " + str);
            Console.WriteLine("String 2 Title = " + str2);

            
        }

        public static void ToUpperFirst()
        {
            string str = "cAPItAlizE first chARAcTer FrOM RaNDom";
            if (!string.IsNullOrEmpty(str))
            {
                StringBuilder sb = new StringBuilder(str.ToLower());
                sb[0] = char.ToUpper(sb[0]);

                Console.WriteLine(sb.ToString());

            }
            else Console.WriteLine(str.ToLower());
        }
    }
}
