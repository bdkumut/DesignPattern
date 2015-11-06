using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
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
            ToplamFiyatVisitor visitor = new ToplamFiyatVisitor();

            foreach (IUrun urun in _sepetUrunleri)
            {
                urun.Accept(visitor);
            }

            return visitor.GetToplamFiyat();
        }
    }
}
