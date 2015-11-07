using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sekil kare = new Kare(new MockCizimProgrami());
            //kare.Ciz();

            Sekil kare = new Kare(new CizimProgramiV1Bridge());
            kare.Ciz();

            Console.ReadKey();
        }
    }
}
