using Harezmi.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Strategy.Hareket
{
    public class Yurumek : IHareketSekli
    {
        public void HareketEt()
        {
            Console.WriteLine("Hayvan yürüyor.");
        }
    }
}
