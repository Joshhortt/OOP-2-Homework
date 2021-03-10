// HOMEWORK - 03 - Mini Project Similar (Inheritance & Interfaces)
using AlternativeInvestments.Interfaces;
using AlternativeInvestments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeInvestments
{
	class Program
	{
		static void Main(string[] args)
		{
            List<ILeaseOption> optionals = new List<ILeaseOption>();
            List<ILeasePurchase> definitiveBuy = new List<ILeasePurchase>();
            List<ILeaseReturn> leaseReturn = new List<ILeaseReturn>();

            var newHomeOwner = new CandidateNewAspiringHomeOwner { DealerFee = 25, LeaseChoice = "Qualified for 2 Lease choices with option to Buy." };
            var goodCreditScore = new CandidateWithGoodCreditScore { LeaseChoice = "Qualified for Imediate Buy.", NumberOfPoints = 580 };
            var nonHousingDebt = new CandidateWithSomeNonHousingDebt { LeaseChoice = "Not Qualified for Imediate Buy.", QuantityAvailable = 4 };

            optionals.Add(newHomeOwner);
            leaseReturn.Add(nonHousingDebt);
            definitiveBuy.Add(goodCreditScore);
            definitiveBuy.Add(newHomeOwner);

            Console.Write("\nDo you want to lease or purchase a property: (lease, purchase, return) ");
            string leasingDecision = Console.ReadLine();

            if (leasingDecision.ToLower() == "lease")
            {
                foreach (var property in optionals)
                {
                    Console.WriteLine($"Item: { property.LeaseChoice }");
                    Console.Write("Do you want to lease this property (yes/no): ");
                    string wantToLease = Console.ReadLine();

                    if (wantToLease.ToLower() == "yes")
                    {
                        property.OptionBuy();
                    }

                    Console.Write("Do you want to return this property (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        property.OptionReturn();
                    }
                }
            }

            if (leasingDecision.ToLower() == "return")
            {
                foreach (var property in leaseReturn)
                {
                    Console.WriteLine($"Item: { property.LeaseChoice }");
                    Console.Write("Do you want to lease and than return this property (yes/no): ");
                    string haveToReturn = Console.ReadLine();

                    if (haveToReturn.ToLower() == "yes")
                    {
                        property.Return();
                    }
                }
            }

            else 
            {
                foreach (var property in definitiveBuy)
                {
                    Console.WriteLine($"Item: { property.LeaseChoice }");
                    Console.Write("Do you want to puchase this property (yes/no): ");
                    string wantToBuy = Console.ReadLine();

                    if (wantToBuy.ToLower() == "yes")
                    {
                        property.Purchase();
                    }
                }
            }
            Console.WriteLine("Congratulations!");

            Console.ReadLine();
        }
	}
}
