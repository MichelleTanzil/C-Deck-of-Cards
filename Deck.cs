using System;
using System.Collections.Generic;
namespace deckOfCards
{
    public class Deck
    {

        public List<Card> cards = new List<Card>();

        // Construct Deck
        public Deck()
        {
            BuildDeck();
        }

        public List<Card> BuildDeck()
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

        public List<Card> Shuffle()
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
        public List<Card> Reset()
        {
            cards.Clear();
            BuildDeck();
            return cards;
        }
    }
}