using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class FiyatListesiExpression : IExpression<FiyatListesi>
    {
        private FiyatKalemiExpression _fiyatKalemiExpression = new FiyatKalemiExpression();

        public FiyatListesi Evaluate(Context context)
        {
            FiyatListesi fiyatListesi = new FiyatListesi();

            while (context.HasNext())
            {
                FiyatKalemi fiyatKalemi = _fiyatKalemiExpression.Evaluate(context);
                fiyatListesi.Ekle(fiyatKalemi);
            }

            return fiyatListesi;
        }
    }
}
