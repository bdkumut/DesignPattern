using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public class Ajans : IObservable
    {
        private List<IObserver> observers;

        public Ajans()
        {
            observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            if (observer != null && observers.Contains(observer))
                observers.Remove(observer);
        }

        public void Notify(string mesaj)
        {
            Haber haber = new Haber(mesaj);

            observers.ForEach(x => x.Update(haber));
        }
    }
}
