using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prvi zadatak
            double a = 1, b = 2, c = 3, d = 4;
            double x= (a*2 + b*2 + c*2 + d*2) / ((a + b) * 2 + (c + d) * 2 );

            Console.WriteLine(x);
            Console.ReadKey();

            //drugi zadatak

            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";

            string s3 = s1.Remove(8);
            s3 = s3.Insert(7, s2.Substring(7));
            Console.WriteLine(s3);
            Console.ReadKey();

            //treci zadatak

            Console.WriteLine("Upisi te neku recenicu");
            string recenica = Console.ReadLine();
            string[] polje = recenica.Split(' ');
            Console.WriteLine(polje[0] + polje[polje.Length-1]);
            Console.ReadKey();

            //cetvrti zadatak

            string korisnik = Console.ReadLine();
            string[] polje1 = korisnik.Split(' ');
            int cijeli = Convert.ToInt32(polje1[0]) * 2;
            double decimalni = Convert.ToDouble(polje1[1]) * 2;
            Console.WriteLine(cijeli + " " + decimalni);

            Console.ReadKey();
        }
    }
}
