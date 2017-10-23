using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Wafer : Sweet
    {
        public Wafer(double weight, double price, string name, double sugar)
           : base(weight, price, name, sugar)
        { }

        public Wafer()
        { }
    }
}
