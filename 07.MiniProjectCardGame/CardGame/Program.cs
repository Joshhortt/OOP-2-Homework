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
		protected List<PlayingCard> fullDeck = new List<PlayingCard>();  // 12.
		protected List<PlayingCard> drawPile = new List<PlayingCard>();  // 13.
		protected List<PlayingCard> discardPile = new List<PlayingCard>();  // 14.


		protected void CreateDeck()  // 8. Method   // 34.  change from private to protected 
		{
			fullDeck.Clear();  // 18. Clear

		for (int suit = 0; suit < 4; suit++)  // 15.
			{
				for (int val = 0; val < 13; val++)  // 16.
				{
					fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (int)(CardValue)val });    // 17.
				}
			}
		}

		public virtual void ShuffleDeck()  // 9. Virtual method
		{
			var rnd = new Random();  // 19. 
			drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();  // 20. Lambda Expression OrderBy a number
		}

		public abstract List<PlayingCard> DealCards(); // 10. Abstract List
		
		protected virtual PlayingCard DrawOneCard()  // 11.  public virtual method RequestCard  / 39. change public to protected & rename to 'DrawOneCard' (everywhere).
		{
			PlayingCard output = drawPile.Take(1).First();  // 21.
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
		public override List<PlayingCard> DealCards()   // 25.
		{
			List<PlayingCard> output = new List<PlayingCard>();   // 26.

			for (int i = 0; i < 5; i++)    // 27. Poker you get 5 cards
			{
				output.Add(DrawOneCard());    // 28.
			}
			return output;    // 29.
		}

		public List<PlayingCard> RequestCards(List<PlayingCard> cardsToDiscard)   // 34.
		{
			List<PlayingCard> output = new List<PlayingCard>();     // 35.

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
		public override List<PlayingCard> DealCards()  // 41. Create override automatically from 40.
		{ 
			List<PlayingCard> output = new List<PlayingCard>();   // 42.

			for (int i = 0; i < 2; i++)    // 43. In Blackjack you get 2 cards
			{
				output.Add(DrawOneCard());    // 44.
			}
			return output;    // 45.
		}
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
