namespace deckOfCards
{
    public class Card
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
}