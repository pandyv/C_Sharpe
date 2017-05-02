using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    public class Bus : Car
    {
        public TypeEngine engine;

        public Bus(string carName, int carCost, int carConsumption, int carSpeed, TypeEngine engine)
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
