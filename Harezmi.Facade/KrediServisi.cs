using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Facade
{
    public class KrediServisi
    {
        public bool BorcKontrol(string tcNo)
        {
            Random random = new Random();

            int value = random.Next(1, 1000);

            if (value < 100)
            {
                return false;
            }

            return true;
        }
    }
}
