using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe(new TrakyaliAsci());

            Console.WriteLine(cafe.Manti().GetYiyecekAdi());
            Console.WriteLine(cafe.Corba().GetYiyecekAdi());

            Console.WriteLine();

            cafe.Asci = new EgeliAsci();

            Console.WriteLine(cafe.Manti().GetYiyecekAdi());
            Console.WriteLine(cafe.Corba().GetYiyecekAdi());

            Console.ReadKey();
        }
    }
}
