using System;
using System.Collections.Generic;
using System.Text;

namespace Harezmi.Iterator
{
    class MyAggregate : IAggregate
    {
        List<string> values_ = null;

        public MyAggregate()
        {
            values_ = new List<string>();
        }

        #region IAggregate Members

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }

        #endregion

        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {                
                values_.Add(value);                                
            }
        }

        public int Count
        {
            get
            {
                return values_.Count;
            }
        }
    }
}
