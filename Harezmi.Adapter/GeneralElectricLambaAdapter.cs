using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Adapter
{
    public class GeneralElectricLambaAdapter: IHarezmiLamba
    {
        private GeneralElectricLamba _generalElectricLamba = new GeneralElectricLamba();

        public GeneralElectricLambaAdapter()
        {
            _generalElectricLamba.Init();
        }

        public void Ac()
        {
            _generalElectricLamba.AcGeneralElectric();
        }

        public void Kapat()
        {
            _generalElectricLamba.KapatGeneralElectric();
        }
    }
}
