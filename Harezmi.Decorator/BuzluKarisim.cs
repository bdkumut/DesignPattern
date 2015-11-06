using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Decorator
{
    public class BuzluKarisim : Karisim 
    {
        public BuzluKarisim(IIcecek icecek)
            : base(icecek)
        {

        }

        public override string GetName()
        {
            return "buzlu " + base.Icecek.GetName();
        }
    }
}
