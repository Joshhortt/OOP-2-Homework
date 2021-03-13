// HOMEWORK - 07 - Mini-Project Card Game (Access Modifiers; Abstract Classes; Method Overriding)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine();  // 1.
		}
	}

	public abstract class Deck  // 7. Abstract Class
	{
		public void CreateDeck()  // 8. Method
		{
		
		}

		public virtual void ShuffleDeck()  // 9. Virtual method
		{

		}
		public abstract List<PlayingCard> DealCard();  // 10. Abstract List

		//public virtual PlayingCard RequestCard()  // 11.  Virtual method
		//{

		//}

	}

	public class PlayingCard  // 2. Method
	{
		public CardSuit Suit { get; set; }  // 3. property
		public int Value { get; set; }  // 4. property
	}

	public enum CardValue // 6. enum
	{
		Ace,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King
	}

	public enum CardSuit  // 5. enum
	{
			Hearts,
			Clubs,
			Diamonds,
			Spades
	}
}
