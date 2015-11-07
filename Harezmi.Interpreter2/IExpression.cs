using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public interface IExpression<T>
    {
        T Evaluate(Context context);
    }
}
