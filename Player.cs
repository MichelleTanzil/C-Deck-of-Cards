using System.Collections.Generic;
namespace deckOfCards
{
    public class Player
    {
		public string Name;
		public List<Card> Hand;

		public Player(string name)
		{
			Name = name;
			Hand = new List<Card>();
		}
		public Card DrawCard(Deck cards)
		{
			Card CardToAdd = cards.DealTopCard();
			Hand.Add(CardToAdd);
			return CardToAdd;
		}
		public Card DiscardCard(int idx)
		{
			if (idx <= Hand.Count - 1 && idx > 0)
			{
                Card CardToRemove = Hand[idx];
                Hand.RemoveAt(idx);
				return CardToRemove;
			}
			else
			{
				return null;
			}
		}
    }
}