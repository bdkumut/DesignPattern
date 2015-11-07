using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class AdExpression : IExpression<string>
    {
        public string Evaluate(Context context)
        {
            return context.NextToken();
        }
    }
}
