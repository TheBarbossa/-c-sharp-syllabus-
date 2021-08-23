namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double startKilometers;
        private double endKilometers;
        private double _liters;
        public Car(double startOdo)
        { startKilometers = startOdo; }
        public double CalculateConsumption()
        {
            return (endKilometers - startKilometers) / _liters;
        }
        private double ConsumptionPer100Km()
        {
            return _liters / (endKilometers - startKilometers) * 100;
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
            _liters = liters;
            endKilometers = mileage;
        }
    }
}
