using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NY_Gift.Interfaces;

namespace NY_Gift.Classes
{
    public class Packaging : Weighted_Element
    {

        public override double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0 || value > 1000)
                    Console.WriteLine("Error!");
                else
                    _price = value;
            }
        }

        public override double Price
        {
            get { return _price; }
            set
            {
                if (value < 0 || value > 1000)
                    Console.WriteLine("Error!");
                else
                    _price = value;
            }
        }

        public Packaging() { }

        public Packaging(double weight, double price, string name)
            :base(weight, price, name)
        { }

    }
}
