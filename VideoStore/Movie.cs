namespace VideoStore
{
	public class Movie 
	{
		public const int CHILDRENS = 2;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		private readonly string _title;

		public Movie(string title, int priceCode) 
		{
			_title = title;
			PriceCode = priceCode;
		}

	    public int PriceCode { get; set; }

		public string Title 
		{
            get {
                if (PriceCode == 1)
                return _title + " (New)";
                return _title;
            }
			
		}
	}
}