using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(string mesaj);
    }
}
