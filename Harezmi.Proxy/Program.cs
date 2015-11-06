using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();

            PersonelServisTxProxy proxy = new PersonelServisTxProxy(new PersonelServisi());

            proxy.Guncelle(personel);

            Console.ReadKey();
        }
    }
}
