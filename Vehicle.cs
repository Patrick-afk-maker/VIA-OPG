using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Vehicle
    {
        private string LicensePlate;
        private double weight;

        public Vehicle(string LicensePlate, double weight) 
        { 

        }
        public string getLicensePlate()
        {
            return LicensePlate;
        }

        public double getWeight()
        {
            return 0.0;
        }
        public string toString()
        {
            return "";
        }

        public bool equals(Vehicle other)
        {
            return this == other;
        }
    }
}
