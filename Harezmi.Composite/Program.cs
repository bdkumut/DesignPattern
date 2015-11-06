using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            AlisverisSepeti alisverisSepeti = new AlisverisSepeti();

            alisverisSepeti.Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Bardak())
                .Ekle(new KolaBardakFirsatUrunu())
                .Ekle(new KolaBardakFirsatUrunu());

            //TEST XXXXXXXX;

            Console.WriteLine(alisverisSepeti.GetToplamFiyat());

            Console.ReadKey();
        }
    }
}
