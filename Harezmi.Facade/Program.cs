using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                TcNo = "8811",
                AdSoyad = "Mahmut Koz",
                HesapNo = "817"
            };

            MorgageServisi morgageServisi = new MorgageServisi();

            bool result = morgageServisi.Basvur(musteri);

            if (result)
            {
                Console.WriteLine("Basvurunuz kabul edildi.");
            }
            else
            {
                Console.WriteLine("Basvurunuz reddedildi.");
            }

            Console.ReadKey();
        }
    }
}
