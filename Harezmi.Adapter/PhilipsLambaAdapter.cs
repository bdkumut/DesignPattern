using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Adapter
{
    public class PhilipsLambaAdapter : IHarezmiLamba
    {
        private PhilipsLamba _philipsLamba = new PhilipsLamba();

        public void Ac()
        {
            _philipsLamba.AcPhilips();
        }

        public void Kapat()
        {
            _philipsLamba.KapatPhilips();
        }
    }
}
