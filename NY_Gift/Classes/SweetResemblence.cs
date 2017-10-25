using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NY_Gift.Classes
{
    public class SweetResemblence : EqualityComparer<Sweet>
    {
        public override bool Equals(Sweet b1, Sweet b2)
        {
            if (b1.Name == b2.Name && b1.Price == b2.Price
                                && b1.Weight == b2.Weight && b1.Sugar == b2.Sugar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Sweet obj)
        {
            throw new NotImplementedException();
        }
    }
}

