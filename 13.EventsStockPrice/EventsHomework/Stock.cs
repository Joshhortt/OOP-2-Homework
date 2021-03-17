using System;

namespace EventsHomework
{
	public class Stock
    {
		private string symbol;
		private decimal price;

        public Stock(string symbol) { this.symbol = symbol; }

        public event EventHandler PriceChanged;

        protected virtual void OnPriceChanged(EventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

		public decimal Price
		{
			get { return price; }
			set
			{
				if (price == value) return;
				price = value;
				OnPriceChanged(EventArgs.Empty);
			}
		}

		public Stock(decimal price)
		{
			Price = price;
		}
	}
}