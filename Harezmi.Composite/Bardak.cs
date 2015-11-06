using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Composite
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
    }
}
