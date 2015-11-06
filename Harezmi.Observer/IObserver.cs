using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public interface IObserver
    {
        void Update(Haber haber);
    }
}
