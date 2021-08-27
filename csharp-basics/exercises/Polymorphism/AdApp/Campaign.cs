using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private double _totalFee;
        private double _totalCost;
        private List<Advert> campaign;

        public Campaign() 
        {
            campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            campaign.Add(a);
        }

        public void AllCosts()
        {
            foreach (var ads in campaign)
            {
                Console.WriteLine(ads);
                Console.WriteLine($"    : Fee = {ads.Cost()}");
            }
        }

        public double TotalFee()
        {
            foreach (var ads in campaign)
            {
                _totalFee += ads.Cost();
            }
            return _totalFee;
        }

        public double TotalCost()
        {
            foreach (var ads in campaign)
            {
                _totalCost += ads.TotalCost();
            }
            return _totalCost;
        }

        public override string ToString()
        {
            Console.WriteLine("\nAdvert Campaign");
            AllCosts();
            Console.WriteLine("\n\nTotal Fee = " + TotalFee());
            return "\nTotal Cost = " + TotalCost();
        }
    }
}