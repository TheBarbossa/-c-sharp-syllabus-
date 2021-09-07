namespace AdApp
{
    public class TVAd: Advert
    {
        private int _baseCost;
        private int _fee;
        private int _time;
        private bool _peakTime;

        public TVAd(int baseCost, int fee, int time, bool peakTime) : base(fee)
        {
            _baseCost = baseCost;
            _time = time;
            _peakTime = peakTime;
            _fee = fee;
        }

        public new double Cost()
        {
            return _peakTime ? _fee * _time * 2 + _baseCost : _fee * _time + _baseCost;
        }

        public override double TotalCost()
        {
            return base.TotalCost() + Cost();
        }

        public override string ToString()
        {
            return "\nTV Ads: Total Cost = " + Cost();
        }
    }
}