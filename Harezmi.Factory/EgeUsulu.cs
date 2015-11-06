using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Factory
{
    public class EgeUsulu: YoreUsulu
    {
        public EgeUsulu(IYiyecek yiyecek)
            : base(yiyecek)
        {

        }

        public override string GetYiyecekAdi()
        {
            return "Ege Usulü " + base.Yiyecek.GetYiyecekAdi();
        }
    }
}
