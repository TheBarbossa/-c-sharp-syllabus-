using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _dimensions;
        private int _copies;
        private int _fee;

        public Poster(int dimensions, int copies, int fee) : base(fee)
        {
            _dimensions = dimensions;
            _copies = copies;
            _fee = fee;
        }

        public new double Cost()
        {
            return Math.Pow(_dimensions,2) * _copies * _fee;
        }

        public override double TotalCost()
        {
            return base.TotalCost() + Cost();
        }

        public override string ToString()
        { 
            return "\nPoster: Total Cost = " + Cost();
        }
    }
}
