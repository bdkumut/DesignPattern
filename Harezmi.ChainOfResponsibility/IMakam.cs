using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public interface IMakam
    {
        void Degerlendir(Talep talep);
    }
}
