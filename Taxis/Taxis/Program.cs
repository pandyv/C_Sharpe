using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxis1.Cars;
using Taxis1.Factory;

namespace Taxis1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Picker[] pickers = new Picker[4];
            Picker[] pickers = new Picker[2];
            pickers[0] = new PickerPassenger();
            pickers[1] = new PickerBus();
           // pickers[2] = new PickerPassenger();
           // pickers[3] = new PickerBus();

            ITaxis taxis = new Taxis();

            foreach (Picker i in pickers)
            {
                if (i is PickerBus)
                {
                    taxis.Add(i.FactoryMethod("Ford", 15000, 15, 180, TypeEngine.Diesel));
                    taxis.Add(i.FactoryMethod("Mers", 20000, 14, 200, TypeEngine.Diesel));
                     }

                if (i is PickerPassenger)
                {
                    taxis.Add(i.FactoryMethod("Ford", 10000, 10, 210, TypeEngine.Diesel));
                    taxis.Add(i.FactoryMethod("Fiat", 9000, 9, 190, TypeEngine.Petrol));
                }
             
               
            }
            taxis.Sort();
            taxis.ShowItems();

            Console.WriteLine();
            foreach (var items in taxis.FindCarSpeed(20, 200))
            {
                Console.WriteLine("Авто: {0}, Скорость: {1}", items.name, items.speed);
            }

            Console.WriteLine();
            Console.WriteLine("Таксопарк стоимость: {0}", taxis.CarCost());

            Console.ReadKey();
        }
    }
}
