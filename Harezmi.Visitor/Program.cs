using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            AlisverisSepeti alisverisSepeti = new AlisverisSepeti();

            alisverisSepeti
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new Kola())
                .Ekle(new KolaBardakFirsatUrunu())
                .Ekle(new KolaBardakFirsatUrunu())
                ;

            Console.WriteLine(alisverisSepeti.GetToplamFiyat());

            Console.ReadKey();
        }
    }
}
