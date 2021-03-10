using AlternativeInvestments.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeInvestments.Models
{
	public class CandidateWithSomeNonHousingDebt : RentToOwnHomesModel, ILeaseReturn
	{
		public void Return()
		{
			QuantityAvailable += 1;
			Console.WriteLine("You can lease the property but you have to return it at the end of the lease.");
		}
	}
}
