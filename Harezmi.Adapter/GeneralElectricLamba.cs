using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Adapter
{
    public class GeneralElectricLamba
    {
        public GeneralElectricLamba()
        {

        }

        public void AcGeneralElectric()
        {
            Console.WriteLine("GeneralElectric lamba açıldı.");
        }

        public void KapatGeneralElectric()
        {
            Console.WriteLine("GeneralElectric lamba kapatıldı.");
        }

        public void Init()
        {
            Console.WriteLine("GeneralElectric lamba init.");
        }
    }
}
