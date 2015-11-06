using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.StateEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            KahveOtomati otomat = new KahveOtomati();

            otomat.ParaEkle(0.5m);
            otomat.SiparisVer(KahveOtomati.KahveTuru.ORTA);
        }
    }
}
