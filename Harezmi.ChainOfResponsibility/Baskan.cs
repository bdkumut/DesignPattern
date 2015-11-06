using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public class Baskan : IMakam
    {
        public void Degerlendir(Talep talep)
        {
            talep.Makam = this;

            if (talep.Tutar <= 100000m)
            {
                talep.Onayla();
            }
            else
            {
                talep.Reddet();
            }
        }
    }
}
