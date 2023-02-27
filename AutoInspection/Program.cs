using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInspection
{
    class Program
    {
        static void Main()
        {
            Car[] cars = new Car[6];
            cars[0] = new Car();
            cars[1] = new Car();
            cars[2] = new Car();
            cars[3] = new Car();
            cars[4] = new Car();
            cars[5] = new Car();

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein: ");

            string searchTerm = Console.ReadLine();

            Console.WriteLine("Suchbegriff ist: " + searchTerm);

            Console.WriteLine("Folgende Autos wurden gefunden: ");

            foreach (Car car in cars)
            {
                if(car.carName.Contains(searchTerm))
                Console.WriteLine(car);
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }

    }
}
