using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public class ProjeYoneticisi : IMakam
    {
        public void Degerlendir(Talep talep)
        {
            talep.Makam = this;

            if (talep.Tutar <= 5000m)
            {
                talep.Onayla();
            }
        }
    }
}
