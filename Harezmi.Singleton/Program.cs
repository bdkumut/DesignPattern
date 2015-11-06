using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe(TrakyaliAsci.Instance);

            Console.WriteLine(cafe.Manti().GetYiyecekAdi());
            Console.WriteLine(cafe.Corba().GetYiyecekAdi());

            Console.WriteLine(TrakyaliAsci.Instance.Hazirla(YiyecekTuru.CORBA).GetYiyecekAdi());

            Console.WriteLine();

            cafe.Asci = EgeliAsci.Instance;

            Console.WriteLine(cafe.Manti().GetYiyecekAdi());
            Console.WriteLine(cafe.Corba().GetYiyecekAdi());

            Console.WriteLine(EgeliAsci.Instance.Hazirla(YiyecekTuru.CORBA).GetYiyecekAdi());

            Console.ReadKey();
        }
    }
}
