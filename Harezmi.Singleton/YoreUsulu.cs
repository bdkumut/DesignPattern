using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Singleton
{
    public abstract class YoreUsulu : IYiyecek
    {
        protected IYiyecek Yiyecek { get; set; }

        public YoreUsulu(IYiyecek yiyecek)
        {
            Yiyecek = yiyecek;
        }

        public abstract string GetYiyecekAdi();
    }
}
