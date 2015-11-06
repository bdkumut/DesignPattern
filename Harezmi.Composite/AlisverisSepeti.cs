using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Harezmi.Composite
{
    public class AlisverisSepeti
    {
        private List<IUrun> _sepetUrunleri = new List<IUrun>();

        public ReadOnlyCollection<IUrun> GetUrunler()
        {
            return new ReadOnlyCollection<IUrun>(_sepetUrunleri);
        }

        public AlisverisSepeti Ekle(IUrun urun)
        {
            _sepetUrunleri.Add(urun);
            return this;
        }

        public AlisverisSepeti Cikar(IUrun urun)
        {
            _sepetUrunleri.Remove(urun);
            return this;
        }

        public decimal GetToplamFiyat()
        {
            decimal total = 0m;

            foreach (IUrun urun in _sepetUrunleri)
            {
                total += urun.GetBirimFiyati();
            }

            return total;
        }
    }
}
