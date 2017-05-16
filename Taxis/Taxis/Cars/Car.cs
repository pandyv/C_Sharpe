using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    public abstract class Car
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }
        public int Consumption { get; private set; }
        public int Speed { get; private set; }

        public Car (string carName, int carCost, int carConsumption, int carSpeed)
        {
            this.Name = carName;
            this.Cost = carCost;
            this.Consumption = carConsumption;
            this.Speed = carSpeed;

        }

        public abstract void TypeCar();
    }
}
