using System.Diagnostics.Tracing;

namespace AdApp
{
    public class Hoarding: Advert
    {
        protected int _baseCost;
        protected int _numDays;
        protected int _fee;
        protected bool _primeLocation;

        public Hoarding(int baseCost, int days, int fee, bool primeLocation) : base(fee)
        {
            _numDays = days;
            _baseCost = baseCost;
            _fee = fee;
            _primeLocation = primeLocation;
        }

        public new double Cost()
        {
            return (_primeLocation) ? (_fee * .5 + _fee) * _numDays + _baseCost : _fee * _numDays + _baseCost;
        }

        public override double TotalCost()
        {
            return base.TotalCost() + Cost();
        }

        public override string ToString()
        {
            return "\nHoarding: Total Cost = " + Cost();
        }
    }
}