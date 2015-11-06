using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class BakiyeYeterliState : AbstractOtomatState
    {
        public BakiyeYeterliState(KahveOtomati otomat) : base(otomat)
        {

        }

        public override void SiparisVer(KahveOtomati.KahveTuru tur)
        {
            base.Otomat.Bakiye = 0;
            base.Otomat.SetState(KahveOtomati.OtomatState.KAHVE_HAZIR);
        }

        public override void ParaIadeEt()
        {
            base.Otomat.Bakiye = 0;
            base.Otomat.SetState(KahveOtomati.OtomatState.BEKLEMEDE);
        }
    }
}
