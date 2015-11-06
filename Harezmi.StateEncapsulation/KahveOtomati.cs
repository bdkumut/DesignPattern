using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public class KahveOtomati : IOtomatState
    {
        public enum OtomatState
        {		
            BEKLEMEDE, 
            BAKIYE_YETERSIZ, 
            BAKIYE_YETERLI, 
            KAHVE_HAZIR
        }

        public enum KahveTuru
        {
            SADE,
            ORTA,
            SEKERLI
        }

        public decimal Bakiye { get; set; }

        private IOtomatState _state;

        public KahveOtomati()
        {
            Bakiye = 0m;
            _state = Ortam.Instance.GetOtomatState(OtomatState.BEKLEMEDE, this);
        }

        public void ParaEkle(decimal miktar)
        {
            _state.ParaEkle(miktar);
        }

        public void SiparisVer(KahveTuru tur)
        {
            _state.SiparisVer(tur);
        }

        public void KahveyiAl()
        {
            _state.KahveyiAl();
        }

        public void ParaIadeEt()
        {
            _state.ParaIadeEt();
        }

        public void SetState(OtomatState state)
        {
            _state = Ortam.Instance.GetOtomatState(state, this);
        }
    }
}
