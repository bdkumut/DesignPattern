using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public class Yonetim
    {
        private List<IMakam> onayZinciriListesi;

        public Yonetim(params IMakam[] onayZinciri)
        {
            onayZinciriListesi = onayZinciri.ToList();
        }

        public ReadOnlyCollection<IMakam> GetOnayZinciriListesi()
        {
            return new ReadOnlyCollection<IMakam>(onayZinciriListesi);
        }

        public void TalepOnayla(Talep talep)
        {
            foreach (IMakam makam in onayZinciriListesi)
            {
                makam.Degerlendir(talep);

                if (talep.Status != TalepStatus.ONAYDA)
                {
                    break;
                }
            }
        }
    }
}
