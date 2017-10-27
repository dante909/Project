using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NY_Gift.Interfaces;

namespace NY_Gift.Classes
{
    public class Wafer : Sweet, ICalority
    {     

        public Wafer()
        { }

        public Wafer(double weight, double price, double sugar, string name)
            :base(weight, price, sugar, name)
        { }

        public double GetCalority()
        {
            return Weight * 342 / 100;
        }
    }
}
