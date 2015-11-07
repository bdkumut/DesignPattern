using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class FiyatKalemiExpression: IExpression<FiyatKalemi>
    {
        private AdExpression _adExpression = new AdExpression();
        private TutarExpression _tutarExpression = new TutarExpression();

        public FiyatKalemi Evaluate(Context context)
        {
            string ad = _adExpression.Evaluate(context);
            decimal fiyat = _tutarExpression.Evaluate(context);

            return new FiyatKalemi(ad, fiyat);
        }
    }
}
