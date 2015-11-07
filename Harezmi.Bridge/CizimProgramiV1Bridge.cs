using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Bridge
{
    public class CizimProgramiV1Bridge:ICizimProgrami
    {
        private CizimProgramiV1 target = new CizimProgramiV1();

        public void CizgiCiz()
        {
            target.CizgiCek();
        }

        public void CemberCiz()
        {
            target.CemberCizdir();
        }
    }
}
