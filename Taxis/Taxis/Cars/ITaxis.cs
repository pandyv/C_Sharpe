using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    public interface ITaxis
    {
        IEnumerable<Car> Items { get; }
        void Add(Car car);
        int CarCost();
        void Sort();
        IEnumerable<Car> FindCarSpeed(int min, int max);
    }
}
