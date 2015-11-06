using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Factory
{
    public class Cafe
    {
        public IAsci Asci { get; set; }

        public Cafe(IAsci asci)
        {
            Asci = asci;
        }

        public IYiyecek Corba()
        {
            return Asci.Hazirla(YiyecekTuru.CORBA);
        }

        public IYiyecek Manti()
        {
            return Asci.Hazirla(YiyecekTuru.MANTI);
        }
    }
}
