using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public class Ajans : IObservable<Haber>
    {
        private List<IObserver<Haber>> observers;

        public Ajans()
        {
            observers = new List<IObserver<Haber>>();
        }

        public IDisposable Subscribe(IObserver<Haber> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Haber>> _observers;
            private IObserver<Haber> _observer;

            public Unsubscriber(List<IObserver<Haber>> observers, IObserver<Haber> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void HaberVer(string mesaj)
        {
            Haber haber = new Haber(mesaj);

            observers.ForEach(x => x.OnNext(haber));
        }
    }
}
