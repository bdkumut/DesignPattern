using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Builder
{
    // This is the "Director" class
    public class Manufacturer
    {
        public void Construct(IPhoneBuilder phoneBuilder)
        {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}
