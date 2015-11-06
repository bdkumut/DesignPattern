using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class Ortam
    {
        private static Ortam instance = new Ortam();

        private Ortam()
        {

        }

        public static Ortam Instance
        {
            get
            {
                return instance;
            }
        }

        public IOtomatState GetOtomatState(KahveOtomati.OtomatState state, KahveOtomati otomat)
        {
            IOtomatState otomatState = null;

            switch (state)
            {   
                case KahveOtomati.OtomatState.BEKLEMEDE:
                    otomatState = new BeklemedeState(otomat);
                    break;
                case KahveOtomati.OtomatState.BAKIYE_YETERSIZ:
                    otomatState = new BakiyeYetersizState(otomat);
                    break;
                case KahveOtomati.OtomatState.BAKIYE_YETERLI:
                    otomatState = new BakiyeYeterliState(otomat);
                    break;
                case KahveOtomati.OtomatState.KAHVE_HAZIR:
                    otomatState = new KahveHazirState(otomat);
                    break;
                default:
                    break;
            }

            return otomatState;
        }
    }
}
