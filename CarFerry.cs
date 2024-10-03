using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class CarFerry
    {
        private string name;
        private double weight;
        private double maxWeight;

        public CarFerry(string name, double weight, double maxWeight)
        { 

        }

        public void addVehicle(Vehicle vehicle)
        {

        }

        public void removeVehicle(Vehicle vehicle)
        {

        }
        public Vehicle getVehicle(string licensePlate)
        {
            Vehicle vehicle = new Vehicle(licensePlate, 0.0);
            return vehicle;
        }
        public double getTotalWeight()
        {
            return weight;
        }
        public Boolean isOverWeight()
        {
            return (maxWeight == 0);
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {

        }
        public double getWeight()
        {
            return 0.0;
        }
        public double getMaxWeight()
        {
            return maxWeight;
        }
    }
}
