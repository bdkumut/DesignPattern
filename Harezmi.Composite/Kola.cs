using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Composite
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
    }
}
