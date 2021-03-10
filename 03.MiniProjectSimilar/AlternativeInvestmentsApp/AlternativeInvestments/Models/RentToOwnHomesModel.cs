using AlternativeInvestments.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeInvestments.Models
{
	public class RentToOwnHomesModel : IRentToOwnHomes
	{
		public string LeaseChoice { get; set; }
		public int QuantityAvailable { get; set; }
	}
}
