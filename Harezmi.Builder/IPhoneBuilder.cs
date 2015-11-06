using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    public interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
