using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NY_Gift.Classes
{
    abstract public class Weighted_Element : Element
    {

        protected double _weight;
        protected double _price;

        public abstract double Price
        {
            get;
            set;
        }

        public abstract double Weight
        {
            get;
            set;
        }

        public Weighted_Element() { }

        public Weighted_Element(double weight, double price, string name)
            :base(name)
        { }

    }
}
