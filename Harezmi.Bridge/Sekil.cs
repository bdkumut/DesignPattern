using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Bridge
{
    public abstract class Sekil
    {
        protected ICizimProgrami CizimProgrami { get; set; }

        public Sekil(ICizimProgrami cizimProgrami)
        {
            CizimProgrami = cizimProgrami;
        }
          
        public abstract void Ciz();
    }
}
