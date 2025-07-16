using FivePrototypes;

namespace FivePrototypes
{
    // Card color options
    public enum CardColor { Red, Green, Blue, Yellow }
    // Card rank options, including symbols
    public enum CardRank
    { 
        One, Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Dollar, Percent, Caret, Ampersand
    }

    // Represents a playing card with color and rank
    class Card
    {
        public CardColor Color  { get; }
        public CardRank Rank  { get; }

        // Constructor
        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }

        // Returns true if the card is a number card
        public bool IsNumberCard() => (Rank <= CardRank.Ten);
        // Returns true if the card is a symbol card
        public bool IsSymbolCard() => (Rank > CardRank.Ten);

        // String representation for easy display
        public override string ToString()
        {
            string rankStr = Rank switch
            {
                CardRank.Ampersand => "&",
                CardRank.Caret => "^",
                CardRank.Dollar => "$",
                CardRank.Percent => "%",
                _ => Rank.ToString()
            };
            return $"The {Color} {rankStr}";
        }
    }
}
