using System;
using System.Collections.Generic;
using System.Text;

namespace Harezmi.Iterator
{
    class MyIterator : IIterator
    {
        IAggregate aggregate_ = null;
        int currentIndex_ = 0;

        public MyIterator(IAggregate aggregate)
        {
            aggregate_ = aggregate;
        }

        #region IIterator Members

        public string FirstItem
        {
            get
            {
                currentIndex_ = 0;
                return aggregate_[currentIndex_];
            }
        }

        public string NextItem
        {
            get
            {
                currentIndex_ += 1;

                if (IsDone == false)
                {
                    return aggregate_[currentIndex_];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string CurrentItem
        {
            get
            {
                return aggregate_[currentIndex_];
            }
        }

        public bool IsDone
        {
            get
            {
                if (currentIndex_ < aggregate_.Count)
                {
                    return false;
                }
                return true;
            }
        }

        #endregion
    }
}
