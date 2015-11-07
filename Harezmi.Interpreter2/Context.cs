using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.Interpreter2
{
    public class Context
    {
        //private StringTokenizer tokenizer;

        private string[] _tokenArray;
        private int _index;

        public Context(string input)
        {
            //tokenizer = new StringTokenizer(input, "{}:,");

            _tokenArray = input.Split(new char[] { '{', '}', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            _index = -1;
        }

        public bool HasNext()
        {
            if (_index < _tokenArray.Length - 1)
            {
                return true;
            }

            return false;
        }

        public string NextToken()
        {
            _index++;
            return _tokenArray[_index];
        }
    }
}
