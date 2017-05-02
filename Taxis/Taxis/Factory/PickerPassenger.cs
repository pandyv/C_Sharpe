using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxis1.Cars;

namespace Taxis1.Factory
{
    public class PickerPassenger : Picker
    {
        public override Car FactoryMethod(string carName, int carCost, int carConsumption, int carSpeed, TypeEngine engine)
        {
            return new Passenger( carName,  carCost,  carConsumption,  carSpeed,  engine);
        }

    }
}
