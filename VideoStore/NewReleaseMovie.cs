﻿namespace VideoStore
{
    public class NewReleaseMovie : Movie
    {
        public NewReleaseMovie(string title, int priceCode) : base(title, priceCode)
        {
        }

        public int PriceCode
        {
            get { return NEW_RELEASE; }
        }

        public override double CostFor(int daysRented)
        {
            return daysRented * 3;
        }
    }
}