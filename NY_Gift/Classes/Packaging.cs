using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        {
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("Weight {0}, Price {1}, Name {2}", Weight.ToString(), Price.ToString(), Name);
        }

    }
}
