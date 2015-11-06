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

            abone1.Subscribe(ajans);
            abone2.Subscribe(ajans);
            abone3.Subscribe(ajans);
            abone4.Subscribe(ajans);

            ajans.HaberVer("Fenerbahce Şampiyon");

            Console.WriteLine("\n");

            abone2.Unsubscribe();

            ajans.HaberVer("Galatasaray Şampiyon");

            Console.ReadKey();
        }
    }
}
