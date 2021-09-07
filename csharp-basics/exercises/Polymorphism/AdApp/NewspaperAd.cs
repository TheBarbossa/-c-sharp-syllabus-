namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _cm;
        private int _columns;
        private int _fee;

        public NewspaperAd(int cm, int columns, int fee) : base(fee)
        {
            _cm = cm;
            _columns = columns;
            _fee = fee;
        }

        public new double Cost()
        {
            return _cm * _columns * _fee;
        }

        public override double TotalCost()
        {
            return base.TotalCost() + Cost();
        }

        public override string ToString()
        { 
            return "\nNewspaper Ads: Total Cost = " + Cost();
        }
    }
}