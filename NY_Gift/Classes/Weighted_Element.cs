using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    abstract public class Weighted_Element : Element
    {

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Weighted_Element(double weight, string name)
            : base(name)
        {
            Weight = weight;
        }

        public Weighted_Element()
        {

        }
    }
}
