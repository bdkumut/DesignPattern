using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Singleton
{
    public class TrakyaUsulu: YoreUsulu
    {
        public TrakyaUsulu(IYiyecek yiyecek)
            : base(yiyecek)
        {

        }

        public override string GetYiyecekAdi()
        {
            return "Trakya Usulü " + base.Yiyecek.GetYiyecekAdi();
        }
    }
}
