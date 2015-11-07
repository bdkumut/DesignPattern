using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Bridge
{
    public class Kare : Sekil
    {
        public Kare(ICizimProgrami cizimProgrami)
            :base(cizimProgrami)
        {

        }

        public void SetCizimProgrami(ICizimProgrami cizimProgrami)
        {
            base.CizimProgrami = cizimProgrami;
        }

        public override void Ciz()
        {
            base.CizimProgrami.CizgiCiz();
            base.CizimProgrami.CizgiCiz();
            base.CizimProgrami.CizgiCiz();
            base.CizimProgrami.CizgiCiz();
        }
    }
}
