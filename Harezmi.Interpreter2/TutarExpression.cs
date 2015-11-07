using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class TutarExpression : IExpression<decimal>
    {
        public decimal Evaluate(Context context)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberGroupSeparator = string.Empty;
            nfi.NumberDecimalSeparator = ".";

            string fiyatString = context.NextToken();

            return decimal.Parse(fiyatString, NumberStyles.AllowDecimalPoint, nfi);
        }
    }
}
