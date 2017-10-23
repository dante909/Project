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
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Weighted_Element(double weight, double price, string name)
            : base(name)
        {
            Weight = weight;
            Price = price;
        }

        public Weighted_Element()
        {

        }
    }
}
