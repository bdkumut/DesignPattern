using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Adapter
{
    public class HarezmiSwitch
    {
        private IHarezmiLamba _harezmiLamba;

        public HarezmiSwitch(IHarezmiLamba harezmiLamba)
        {
            _harezmiLamba = harezmiLamba;
        }

        public void SetLamba(IHarezmiLamba harezmiLamba)
        {
            _harezmiLamba = harezmiLamba;
        }

        public void On()
        {
            _harezmiLamba.Ac();
        }

        public void Off()
        {
            _harezmiLamba.Kapat();
        }
    }
}
