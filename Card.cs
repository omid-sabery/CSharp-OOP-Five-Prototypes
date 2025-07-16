namespace TicTacToe
{
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank
    { 
        One, Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Dollor, Percent, Caret, Ampersand
    }
    class Card
    {
        // Properties
        public CardColor Color  { get; }
        public CardRank Rank  { get; }

        // Constructors
        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }

        // Methods
        public bool IsNumberCard() => (Rank <= CardRank.Ten);
        public bool IsSymbolCard() => (Rank > CardRank.Ten);

    }
}
