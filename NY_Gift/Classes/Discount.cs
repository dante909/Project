using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Discount : Element
    {
        private double _bonus;

        public Discount(double bonus)
        {
            Bonus = bonus;
        }

        public Discount()
        { }

        public double Bonus
        {
            get { return _bonus; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Error");
                else
                    _bonus = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Discount: {0}%", Bonus.ToString());
        }

    }
}
