using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class SweetEnumerator : IEnumerator<Sweet>
    {
        private NY_Gift _collection;
        private int curIndex;
        private Sweet curSweet;

        public SweetEnumerator(NY_Gift collection)
        {
            _collection = collection;
            curIndex = -1;
            curSweet = default(Sweet);

        }

        public Sweet Current
        {
            get
            {
                return curSweet;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


        public bool MoveNext()
        {
            //Avoids going beyond the end of the collection.
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                
                curSweet = _collection[curIndex];
            }
            return true;
        }

        void IDisposable.Dispose() { }

        public void Reset()
        {
            curIndex = -1;
        }
    }
}
