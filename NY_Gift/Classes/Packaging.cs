using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class Packaging : Weighted_Element
    {
        public Packaging()
        {
        }

        public Packaging(double weight, string name)
            : base(weight, name)
        { }
    }
}
