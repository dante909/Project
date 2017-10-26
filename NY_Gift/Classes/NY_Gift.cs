using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NY_Gift.Classes
{
     public class NY_Gift : ICollection<Sweet>
    {
        private Discount _bonus;
        private Packaging _packaging;
        private List<Sweet> innerCol;

        public NY_Gift(Discount bonus, Packaging packaging)
        {
            innerCol = new List<Sweet>();
            Bonus = bonus;
            Packaging = packaging;
            
        }


        public Discount Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }


        public Sweet this[int index]
        {
            get { return (Sweet)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        public Packaging Packaging
        {
            get { return _packaging; }
            set { _packaging = value; }
        }

        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

       
        public void Add(Sweet item)
        {            
           innerCol.Add(item);           
        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Contains(Sweet item)
        {
            bool found = false;

            foreach (Sweet sw in innerCol)
            {
                if (sw.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public IEnumerator<Sweet> GetEnumerator()
        {
            return new SweetEnumerator(this);
        }

        public bool Remove(Sweet item)
        {
            bool result = false;
            for (int i = 0; i < innerCol.Count; i++)
            {
                Sweet curSweet = (Sweet)innerCol[i];
                if (new SweetResemblence().Equals(curSweet, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }

            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SweetEnumerator(this);
        }

        public void CopyTo(Sweet[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }
    }
}
