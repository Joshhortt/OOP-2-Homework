using AlternativeInvestments.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeInvestments.Models
{
	public class CandidateWithGoodCreditScore : RentToOwnHomesModel, ILeasePurchase
	{
        public int NumberOfPoints { get; set; }

        public void Purchase()
        {
            QuantityAvailable -= 1;
            Console.WriteLine("You can buy the property imediatly without a Rent-to Own-Property-Deal.");
        }
    }
}
