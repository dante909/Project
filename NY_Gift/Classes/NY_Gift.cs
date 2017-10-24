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
        private ArrayList arSweets = new ArrayList();
        private Discount _bonus;
        private Packaging _packaging;

        public Sweet Get_Sweet(int pos)
        { return (Sweet)arSweets[pos]; }


        public void Add_Sweet(Sweet sweet)
        { arSweets.Add(sweet); }


        public void Clear_Sweet()
        { arSweets.Clear(); }


        public int Count
        { get { return arSweets.Count; } }


        IEnumerator IEnumerable.GetEnumerator()
        { return arSweets.GetEnumerator(); }

        public NY_Gift()
        {

        }

        public NY_Gift(ArrayList arrsweets, Discount bonus, Packaging packaging)
        {
            arSweets = arrsweets;
            _bonus = bonus;
            _packaging = packaging;
        }

    }
}
