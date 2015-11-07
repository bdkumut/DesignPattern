using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class FiyatKalemi
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public FiyatKalemi(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }
}
