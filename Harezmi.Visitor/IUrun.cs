using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public interface IUrun
    {
        string GetAdi();
        decimal GetBirimFiyati();
        void Accept(IVisitor visitor);
    }
}
