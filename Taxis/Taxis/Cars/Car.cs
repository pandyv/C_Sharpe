using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    public abstract class Car
    {
        public string name { get; private set; }
        public int cost { get; private set; }
        public int consumption { get; private set; }
        public int speed { get; private set; }

        public Car (string carName, int carCost, int carConsumption, int carSpeed)
        {
            this.name = carName;
            this.cost = carCost;
            this.consumption = carConsumption;
            this.speed = carSpeed;

        }

        public abstract void TypeCar();
    }
}
