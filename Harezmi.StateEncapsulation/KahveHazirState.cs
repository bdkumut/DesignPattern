using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class KahveHazirState : AbstractOtomatState
    {
        public KahveHazirState(KahveOtomati otomat)
            : base(otomat)
        {

        }

        public override void KahveyiAl()
        {
            base.Otomat.SetState(KahveOtomati.OtomatState.BEKLEMEDE);
        }
    }
}
