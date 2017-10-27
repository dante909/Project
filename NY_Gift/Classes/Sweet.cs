using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NY_Gift.Classes
{
    public class Sweet : Weighted_Element, IEquatable<Sweet>, IComparable
    {
        private double _sugar;

        public double Sugar
        {
            get { return _sugar; }
            set
            {
                if (value > 70 || value < 0)
                    throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 70.");
                
                    _sugar = value;
            }
        }

        public override double Price
        {
            get { return _price; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 100.");
                _price = value;
            }
        }

        public override double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 100.");
                _weight = value;
            }
        }
        
        public Sweet() { }

        public Sweet(double weight, double price, double sugar, string name)
            :base(weight, price, name)
        {
            Weight = weight;
            Price = price;
            Sugar = sugar;
        }

        public bool Equals(Sweet other)
        {
            if (new SweetResemblence().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(object obj)
        {
            Sweet temp = obj as Sweet;
            if (temp != null)
            {
                if (this.Weight > temp.Weight)
                    return 1;
                if (this.Weight < temp.Weight)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Parametr is not Sweet!");
        }
    }
}
