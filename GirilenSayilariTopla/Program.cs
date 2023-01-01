using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayilariTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1,sayi2;
            Console.WriteLine("1. Sayıyı Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayi1 + sayi2;

            if (sayi2 == 83)
                Console.WriteLine("Girilen sayıların toplamı" + sonuc);
                    Console.WriteLine("Döngü Bitti.");
            Console.ReadLine();

                





        }
    }
}
