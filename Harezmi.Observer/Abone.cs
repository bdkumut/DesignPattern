using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public class Abone : IObserver<Haber>
    {
        public string Name { get; set; }
        private IDisposable unsubscriber;

        public Abone(string name)
        {
            Name = name;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Haber haber)
        {
            Console.WriteLine(string.Format("Abone: {0}, Haber: {1}", Name, haber.Mesaj));
        }

        public virtual void Subscribe(IObservable<Haber> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
