using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public class BaskanYardimcisi : IMakam
    {
        public void Degerlendir(Talep talep)
        {
            talep.Makam = this;

            if (talep.Tutar <= 50000m)
            {
                talep.Onayla();
            }
        }
    }
}
