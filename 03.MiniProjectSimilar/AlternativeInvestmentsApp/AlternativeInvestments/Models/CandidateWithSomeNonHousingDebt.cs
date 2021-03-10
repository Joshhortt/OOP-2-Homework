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
		//public void OptionBuy()
		//{
		//	QuantityAvailable -= 1;
		//	Console.WriteLine("You are qualified to lease the property and you can buy it, before the end of the lease.");
		//}

		//public void OptionReturn()
		//      {
		//          QuantityAvailable += 1;
		//	Console.WriteLine("You are qualified not to buy the property at the end of the lease, the option simply expires.");
		//}
		public void Return()
		{
			QuantityAvailable += 1;
			Console.WriteLine("You can lease the property but you have to return it at the end of the lease.");
		}
	}
}
