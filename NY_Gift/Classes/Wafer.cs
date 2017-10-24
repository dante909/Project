using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Wafer : Sweet
    {     

        public Wafer()
        { }

        public Wafer(double weight, double price, double sugar, string name)
            :base(weight, price, sugar, name)
        { }

    }
}
