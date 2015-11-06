using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public interface IOtomatState
    {
        void ParaEkle(decimal miktar);
        void SiparisVer(KahveOtomati.KahveTuru tur);
        void KahveyiAl();
        void ParaIadeEt();
    }
}
