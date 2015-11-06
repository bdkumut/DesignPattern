using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Facade
{
    public class MorgageServisi
    {
        private BankaServisi _bankaServisi = new BankaServisi();
        private KrediServisi _krediServisi = new KrediServisi();
        private KrediKartiServisi _krediKartiServisi = new KrediKartiServisi();

        public bool Basvur(Musteri musteri)
        {
            if (_bankaServisi.HesapKontrol(musteri.TcNo) == false)
            {
                return false;
            }

            if (_krediServisi.BorcKontrol(musteri.TcNo) == false)
            {
                return false;
            }

            if (_krediKartiServisi.KrediKartıKontrol(musteri.TcNo) == false)
            {
                return false;
            }

            return true;
        }
    }
}
