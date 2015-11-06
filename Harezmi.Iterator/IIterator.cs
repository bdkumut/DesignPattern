using System;
using System.Collections.Generic;
using System.Text;

namespace Harezmi.Iterator
{
    interface IIterator
    {
        string FirstItem { get;}
        string NextItem{ get;}
        string CurrentItem{ get;}
        bool IsDone { get;}

    }
}
