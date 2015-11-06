using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    public class Abone : IObserver
    {
        public string Name { get; set; }

        public Abone(string name)
        {
            Name = name;
        }

        public void Update(Haber haber)
        {
            Console.WriteLine(string.Format("Abone: {0}, Haber: {1}", Name, haber.Mesaj));
        }
    }
}
