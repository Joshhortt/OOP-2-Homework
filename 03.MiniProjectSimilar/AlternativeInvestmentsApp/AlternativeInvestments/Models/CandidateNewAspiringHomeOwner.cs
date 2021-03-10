using AlternativeInvestments.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeInvestments.Models
{
	public class CandidateNewAspiringHomeOwner : RentToOwnHomesModel, ILeasePurchase, ILeaseOption

	{
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            QuantityAvailable -= 1;
            Console.WriteLine("You can buy the property imediatly without a Rent-to Own-Property-Deal.");
        }

        public void OptionBuy()
        {
            QuantityAvailable -= 1;
            Console.WriteLine("You can lease the property and then buy it, before the end of the lease.");
        }

        public void OptionReturn()
        {
            QuantityAvailable += 1;
            Console.WriteLine("You can lease the property and then return it, at the end of the lease.");
        }
    }
}
