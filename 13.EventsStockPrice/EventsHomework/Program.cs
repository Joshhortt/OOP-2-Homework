// 13 - HOMEWORK - Events
// Create an event in a class then consume that class. Attach a listener to the event and have it write to the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
	class Program
    {
        static void Main(string[] args)
        {
			// The predefined non-generic EventHandler delegate can be used when an event doesn't carry extra information:

			Stock stock = new Stock("Apple")
            // stock.Price = 28.46M;   -- >  simplified version below
            {
				Price = 28.46M
			};

			// Register with the PriceChanged event
			stock.PriceChanged += stock_PriceChanged;
            stock.Price = 29.92M;

            void stock_PriceChanged(object sender, EventArgs e)
            {
                Console.WriteLine("New Stock price is: " + ((Stock)sender).Price);
            }
        }
    }
}