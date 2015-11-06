using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public class ToplamFiyatVisitor : IVisitor
    {
        private int KolaSayisi { get; set; }
        private int BardakSayisi { get; set; }
        private int KolaBardakFirsatUrunSayisi { get; set; }

        private decimal KolaBirimFiyati { get; set; }
        private decimal BardakBirimFiyati { get; set; }
        private decimal KolaBardakFirsatUrunBirimFiyati { get; set; }

        public ToplamFiyatVisitor()
        {
            KolaSayisi = 0;
            BardakSayisi = 0;
            KolaBardakFirsatUrunSayisi = 0;

            KolaBirimFiyati = 0;
            BardakBirimFiyati = 0;
            KolaBardakFirsatUrunBirimFiyati = 0;
        }

        public void Visit(Kola kola)
        {
            KolaSayisi++;
            KolaBirimFiyati = kola.GetBirimFiyati();
        }

        public void Visit(Bardak bardak)
        {
            BardakSayisi++;
            BardakBirimFiyati = bardak.GetBirimFiyati();
        }

        public void Visit(KolaBardakFirsatUrunu kolaBardakFirsatUrunu)
        {
            KolaBardakFirsatUrunSayisi++;
            KolaBardakFirsatUrunBirimFiyati = kolaBardakFirsatUrunu.GetBirimFiyati();
        }

        public decimal GetToplamFiyat()
        {
            decimal toplamFiyat = 0m;

            if (KolaBardakFirsatUrunSayisi > 0)
            {
                toplamFiyat += KolaBardakFirsatUrunBirimFiyati;
                KolaSayisi -= 2;
                BardakSayisi--;
            }

            int alinanBedavaKolaSayisi = KolaSayisi / 6;

            int hesaplanacakKolaSayisi = KolaSayisi - alinanBedavaKolaSayisi;

            toplamFiyat += hesaplanacakKolaSayisi * KolaBirimFiyati;

            toplamFiyat += BardakSayisi * BardakBirimFiyati;

            return toplamFiyat;
        }
    }
}
