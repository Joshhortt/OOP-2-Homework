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
			PokerDeck deck = new PokerDeck();  // 33.
			
			Console.ReadLine();  // 1.
		}
	}

	public abstract class Deck  // 7. Abstract Class
	{
		protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();  // 12.
		protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();  // 13.
		protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();  // 14.


		protected void CreateDeck()  // 8. Method   // 34.  change from private to protected 
		{
			fullDeck.Clear();  // 18. Clear

		for (int suit = 0; suit < 4; suit++)  // 15.
			{
				for (int val = 0; val < 13; val++)  // 16.
				{
					fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (int)(CardValue)val });    // 17.
				}
			}
		}

		public virtual void ShuffleDeck()  // 9. Virtual method
		{
			var rnd = new Random();  // 19. 
			drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();  // 20. Lambda Expression OrderBy a number
		}

		public abstract List<PlayingCardModel> DealCards(); // 10. Abstract List
		
		protected virtual PlayingCardModel DrawOneCard()  // 11.  public virtual method RequestCard  / 39. change public to protected & rename to 'DrawOneCard' (everywhere).
		{
			PlayingCardModel output = drawPile.Take(1).First();  // 21.
			drawPile.Remove(output);   // 22.
			return output;     // 23.
		}
	}


	// Child Classes
	public class PokerDeck : Deck  // 24.
	{
		public PokerDeck()  // 30. Create Constructor
		{
			CreateDeck();   // 31.
			ShuffleDeck();   // 32.
		}
		public override List<PlayingCardModel> DealCards()   // 25.
		{
			List<PlayingCardModel> output = new List<PlayingCardModel>();   // 26.

			for (int i = 0; i < 5; i++)    // 27. Poker you get 5 cards
			{
				output.Add(DrawOneCard());    // 28.
			}
			return output;    // 29.
		}

		public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)   // 34.
		{
			List<PlayingCardModel> output = new List<PlayingCardModel>();     // 35.

			foreach (var card in cardsToDiscard)   // 36.
			{
				output.Add(DrawOneCard());    // 37.
				discardPile.Add(card);   // 38.
			}
			return output;
		}	
	}

	public class BlackjackDeck : Deck  // 40.
	{
		public override List<PlayingCardModel> DealCards()  // 41. Create override automatically from 40.
		{ 
			List<PlayingCardModel> output = new List<PlayingCardModel>();   // 42.

			for (int i = 0; i < 2; i++)    // 43. In Blackjack you get 2 cards
			{
				output.Add(DrawOneCard());    // 44.
			}
			return output;    // 45.
		}
	}
}
