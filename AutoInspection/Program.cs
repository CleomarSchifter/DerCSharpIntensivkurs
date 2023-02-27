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
            string[] carNames = new string[6];
            carNames[0] = "Mercedes G";
            carNames[1] = "Audi A8";
            carNames[2] = "BMW 3";
            carNames[3] = "Audi A6";
            carNames[4] = "Hyundai";
            carNames[5] = "Toyota";

            Console.WriteLine("Bitte geben Sie einen Suchbegriff ein: ");

            string searchTerm = Console.ReadLine();

            Console.WriteLine("Suchbegriff ist: " + searchTerm);

            Console.WriteLine("Folgende Autos wurden gefunden: ");

            foreach (string car in carNames)
            {
                if(car.Contains(searchTerm))
                Console.WriteLine(car);
            }


            Console.ReadKey();
            Console.Clear();
            Main();
        }

    }
}
