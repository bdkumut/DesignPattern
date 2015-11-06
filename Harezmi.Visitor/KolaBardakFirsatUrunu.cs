using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public class KolaBardakFirsatUrunu : FirsatUrunu
    {
        public KolaBardakFirsatUrunu()
        {
            base.Ekle(new Kola()).Ekle(new Kola()).Ekle(new Bardak());
        }

        public override string GetAdi()
        {
            return "2 kola alana bardak bedava";
        }

        public override decimal GetBirimFiyati()
        {
            return 2m;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (IUrun urun in base.GetUrunler())
            {
                urun.Accept(visitor);
            }
        }
    }
}
