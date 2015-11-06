using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan aslan = new Hayvan(4);
            aslan.HareketEt(Ortam.OrtamTipi.KARA);

            Console.WriteLine();

            Hayvan kus = new Hayvan(0);
            kus.HareketEt(Ortam.OrtamTipi.HAVA);

            Console.ReadKey();
        }
    }
}
