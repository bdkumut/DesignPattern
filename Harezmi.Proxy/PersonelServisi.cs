using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Proxy
{
    public class PersonelServisi : IPersonelServisi
    {
        public void Guncelle(Personel p)
        {
           Console.WriteLine("personel güncelleniyor");
        }
    }
}
