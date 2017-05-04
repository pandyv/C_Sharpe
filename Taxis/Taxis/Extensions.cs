using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxis1.Cars;

namespace Taxis1
{
    public static class Extensions
    {
        public static void ShowItems(this ITaxis taxis)
        {
            Console.WriteLine("Таксопарк: ");
            foreach (var i in taxis.Items)
            {
                Console.WriteLine("Автомобиль: {0}, Стоимость: {1}, Расход: {2}, Скорость: {3},", i.name, i.cost, i.consumption, i.speed);
            }

        }
    }
}
