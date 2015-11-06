using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class BakiyeYetersizState : AbstractOtomatState
    {
        public BakiyeYetersizState(KahveOtomati otomat)
            : base(otomat)
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

        public override void ParaIadeEt()
        {
            base.Otomat.Bakiye = 0;
            base.Otomat.SetState(KahveOtomati.OtomatState.BEKLEMEDE);
        }
    }
}
