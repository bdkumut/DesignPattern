using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public abstract class FirsatUrunu : IUrun
    {
        private List<IUrun> _urunler = new List<IUrun>();

        public ReadOnlyCollection<IUrun> GetUrunler()
        {
            return new ReadOnlyCollection<IUrun>(_urunler);       
        }

        public FirsatUrunu Ekle(IUrun urun)
        {
            _urunler.Add(urun);
            return this;
        }

        public FirsatUrunu Cikar(IUrun urun)
        {
            _urunler.Remove(urun);
            return this;
        }
     
        public abstract string GetAdi();

        public abstract decimal GetBirimFiyati();

        public abstract void Accept(IVisitor visitor);
    }
}
