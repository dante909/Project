using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Discount : Element
    {
        private double _discount;

        public Discount(string name, double bonus)
            : base(name)
        {
            Bonis = bonus;
        }

        public Discount()
        { }

        public double Bonis
        {
            get { return _discount; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Error");
                else
                    _discount = value;
            }
        }

    }
}
