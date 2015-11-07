using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class FiyatListesi
    {
        private List<FiyatKalemi> _fiyatKalemleri = new List<FiyatKalemi>();

        public ReadOnlyCollection<FiyatKalemi> GetFiyatKalemleri()
        {
            return new ReadOnlyCollection<FiyatKalemi>(_fiyatKalemleri);
        }

        public FiyatListesi Ekle(FiyatKalemi fiyatKalemi)
        {
            _fiyatKalemleri.Add(fiyatKalemi);
            return this;
        }

        public FiyatListesi Cikar(FiyatKalemi fiyatKalemi)
        {
            _fiyatKalemleri.Remove(fiyatKalemi);
            return this;
        }
    }
}
