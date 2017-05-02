using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxis1.Cars
{
    public enum TypeEngine { Diesel, Petrol, Gas, Electro };

    public class Taxis : ITaxis
    {
        private ICollection<Car> items;

        public Taxis()
        {
            items = new List<Car>();
        }

        public void Add(Car car)
        {
            items.Add(car);
        }

        public int CarCost()
        {
            return items.Sum(x => x.cost);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.consumption).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Car> Items
        {
            get { return this.items; }
        }

        public IEnumerable<Car> FindCarSpeed(int min, int max)
        {
            return items.Where(x => (x.speed >= min) && (x.speed <= max)).ToList();
        }

    }
}
