using System;
using System.Collections.Generic;

namespace deckOfCards
{
  class Card
  {
    public string StringVal;
    public string Suit;
    public int Val;

    public Card(string suit, int val)
    {
      Suit = suit;
      Val = val;

      if (val == 1)
      {
        StringVal = "Ace";
      }
      else if (val == 11)
      {
        StringVal = "Jack";
      }
      else if (val == 12)
      {
        StringVal = "Queen";
      }
      else if (val == 13)
      {
        StringVal = "King";
      }
      else
      {
        StringVal = val.ToString();
      }
    }
  }

  class Deck
  {
    public List<Card> cards = new List<Card>();

    // Construct Deck
    public Deck()
    {
      BuildDeck();
    }

    public Deck BuildDeck()
    {
      string[] suits = { "Spade", "Club", "Heart", "Diamond" };
      for (int suit = 0; suit < suits.Length; suit++)
      {
        for (int val = 1; val <= 13; val++)
        {
          cards.Add(new Card(suits[suit], val));
        }
      }
      return cards;
    }

    public Card DealTopCard()
    {
      Card topCard = cards[0];
      cards.RemoveAt(0);
      return topCard;
    }

    public Deck Reset()
    {
      cards.clear();
      BuildDeck().Shuffle();
      return cards;
    }

    public Deck Shuffle()
    {
      Random rand = new Random();
      for (int i = 0; i < cards.Count; i++)
      {
        Card temp = cards[i];
        int randCard = rand.Next(cards.Count);

        cards[i] = cards[randCard];
        cards[randCard] = temp;
      }
      return cards;
    }
  }

	class Player
	{
		public string Name;
		public List<Card> Hand;

		public Player(string name)
		{
			Name = name;
			Hand = new List<Card>();
		}
		public Card DrawCard()
		{
			Card CardToAdd = Deck.DealTopCard();
			Hand.Add(CardToAdd);
			return CardToAdd;
		}
		public Card DiscardCard(int idx)
		{
			if (idx <= Hand.Count - 1)
			{
				Card CardToRemove = Hand.RemoveAt(idx);
				return CardToRemove;
			}
			else
			{
				return null;
			}
		}
	}

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
