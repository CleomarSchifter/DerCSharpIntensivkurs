

namespace AutoInspection
{
    class Car
    {
        public string carName = "Audi";
        public int baujahr = 1995;
        public int lastInspectionYear = 2010;

        // Konstruktor
        public Car (string newName, int newBauJahr)
        {
            carName = newName;
            baujahr = newBauJahr;
        }
        // Methoden
        public void Inspect()
        {
            lastInspectionYear = 2023;
        }
    }
}
