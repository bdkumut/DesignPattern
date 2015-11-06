using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public class Bardak: IUrun
    {
        public string GetAdi()
        {
            return "bardak";
        }

        public decimal GetBirimFiyati()
        {
            return 0.5m;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
