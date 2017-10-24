using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NY_Gift.Interfaces;

namespace NY_Gift.Classes
{
    abstract public class Element
    {
        private string _name;

        public Element() { }
        public Element(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!");
                else
                    _name = value;
            }
        }
    }
}
