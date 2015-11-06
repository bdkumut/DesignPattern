using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class BeklemedeState : AbstractOtomatState
    {
        public BeklemedeState(KahveOtomati otomat) : base(otomat)
        {

        }

        public override void ParaEkle(decimal miktar)
        {
            base.Otomat.Bakiye = base.Otomat.Bakiye + miktar;

            if (base.Otomat.Bakiye > 1m)
            {
                base.Otomat.SetState(KahveOtomati.OtomatState.BAKIYE_YETERLI);
            }
            else
            {
                base.Otomat.SetState(KahveOtomati.OtomatState.BAKIYE_YETERSIZ);
            }
        }
    }
}
