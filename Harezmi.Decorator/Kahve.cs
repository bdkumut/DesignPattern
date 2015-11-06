using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Decorator
{
    public class Kahve : IIcecek
    {
        public string GetName()
        {
            return "kahve";
        }
    }
}
