using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public class Haber
    {
        public string Mesaj { get; set; }

        public Haber(string mesaj)
        {
            Mesaj = mesaj;
        }
    }
}
