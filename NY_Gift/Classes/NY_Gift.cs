using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace NY_Gift.Classes
{
     public class NY_Gift : IEnumerable
    {
        List<Sweet> _sweets = new List<Sweet>();

        public NY_Gift()
        {

        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_sweets).GetEnumerator();
        }
    }
}
