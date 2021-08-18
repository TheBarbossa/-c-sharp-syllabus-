namespace FuelConsumptionCalculator
{
    public class Car
    {
        public Car(double startOdo)
        { startKilometers = startOdo; }
        private double startKilometers
        { get; set; }
        private double endKilometers
        { get; set; }
        private double Liters
        { get; set; }

        public double CalculateConsumption()
        {
            return (endKilometers - startKilometers) / Liters;
        }

        private double ConsumptionPer100Km()
        {
            return Liters / (endKilometers - startKilometers) * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }
        public void FillUp(int mileage, double liters)
        {
            Liters = liters;
            endKilometers = mileage;
        }
    }
}
