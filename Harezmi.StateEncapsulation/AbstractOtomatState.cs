using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    public abstract class AbstractOtomatState : IOtomatState
    {
        protected KahveOtomati Otomat { get; set; }

        public AbstractOtomatState(KahveOtomati otomat)
        {
            Otomat = otomat;
        }

        public virtual void ParaEkle(decimal miktar)
        {
            throw new NotImplementedException();
        }

        public virtual void SiparisVer(KahveOtomati.KahveTuru tur)
        {
            throw new NotImplementedException();
        }

        public virtual void KahveyiAl()
        {
            throw new NotImplementedException();
        }

        public virtual void ParaIadeEt()
        {
            throw new NotImplementedException();
        }
    }
}
