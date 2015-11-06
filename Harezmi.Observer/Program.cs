using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Abone abone1 = new Abone("Abone1");
            Abone abone2 = new Abone("Abone2");
            Abone abone3 = new Abone("Abone3");
            Abone abone4 = new Abone("Abone4");

            Ajans ajans = new Ajans();

            ajans.Subscribe(abone1);
            ajans.Subscribe(abone2);
            ajans.Subscribe(abone3);
            ajans.Subscribe(abone4);

            ajans.Notify("Fenerbahce Şampiyon");

            Console.WriteLine("\n");

            ajans.Unsubscribe(abone3);

            ajans.Notify("Galatasaray Şampiyon");

            Console.ReadKey();
        }
    }
}
