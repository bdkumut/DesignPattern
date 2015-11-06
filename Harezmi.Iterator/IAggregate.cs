using System;
using System.Collections.Generic;
using System.Text;

namespace Harezmi.Iterator
{
    interface IAggregate
    {
        IIterator GetIterator();
        string this[int itemIndex] { set; get; }
        int Count { get; }
    }
}
