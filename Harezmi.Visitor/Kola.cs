using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public class Kola : IUrun
    {
        public string GetAdi()
        {
            return "kola";
        }

        public decimal GetBirimFiyati()
        {
            return 1m;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
