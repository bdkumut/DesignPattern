using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Proxy
{
    public class PersonelServisTxProxy: IPersonelServisi
    {
        private IPersonelServisi _personelServisi;

        public PersonelServisTxProxy(IPersonelServisi personelServisi)
        {
            _personelServisi = personelServisi;
        }

        public void Guncelle(Personel p)
        {
            try
            {
                Console.WriteLine("tx begin");

                _personelServisi.Guncelle(p);

                Console.WriteLine("tx commit");
            }
            catch (Exception ex)
            {
                Console.WriteLine("tx rollback");
            }
        }
    }
}
