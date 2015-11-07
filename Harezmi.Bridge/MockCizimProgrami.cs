using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Bridge
{
    class MockCizimProgrami : ICizimProgrami
    {
        public void CizgiCiz()
        {
            Console.WriteLine("MockCizimProgrami ile çizgi çiziliyor");
        }

        public void CemberCiz()
        {
            Console.WriteLine("MockCizimProgrami ile çember çiziliyor");
        }
    }
}
