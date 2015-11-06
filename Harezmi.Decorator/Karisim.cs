using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Decorator
{
    public abstract class Karisim : IIcecek
    {
        protected IIcecek Icecek { get; set; }

        public Karisim(IIcecek icecek)
        {
            Icecek = icecek;
        }

        public abstract string GetName();
    }
}
