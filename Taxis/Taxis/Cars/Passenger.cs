using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    //public enum TypeEngine { Diesel, Petrol, Gas, Electro }

    public class Passenger : Car
    {
        public TypeEngine engine;

        public Passenger(string carName, int carCost, int carConsumption, int carSpeed, TypeEngine engine)
                : base (carName,  carCost,  carConsumption,  carSpeed)
            {
                this.engine = engine;
            }
        public override void TypeCar()
            {
                Console.WriteLine(engine.ToString());
            }
        
    }
}
