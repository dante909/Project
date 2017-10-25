﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NY_Gift.Classes
{
    public class Sweet : Weighted_Element, IEquatable<Sweet>
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

        public override double Price
        {
            get { return _price; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Error!");
                else
                    _price = value;
            }
        }

        public override double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Error!");
                else
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
    }
}
