using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Visitor
{
    public interface IVisitor
    {
        void Visit(Kola kola);
        void Visit(Bardak bardak);
        void Visit(KolaBardakFirsatUrunu kolaBardakFirsatUrunu);
    }
}
