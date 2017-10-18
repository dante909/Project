using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Sweet : Weighted_Element
    {
        private double _sugar;

        public double Sugar
        {
            get { return _sugar; }
            set
            {
                if (value > 50 || value < 0)
                    Console.WriteLine("Error");
                else
                    _sugar = value;
            }
        }

        public Sweet()
        {
        }

        public Sweet(double weight, string name, double sugar)
            : base(weight, name)
        {
            Sugar = sugar;
        }
    }
}
