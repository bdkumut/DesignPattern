using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Decorator
{
    public class SutluKarisim : Karisim 
    {
        public SutluKarisim(IIcecek icecek)
            : base(icecek)
        {

        }

        public override string GetName()
        {
            return "sütlü " + base.Icecek.GetName();
        }
    }
}
