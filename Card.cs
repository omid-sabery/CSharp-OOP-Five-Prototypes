namespace TicTacToe
{
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank
    { 
        One, Two, Three, Four, Five,
        Six, Seven, Eight, Nine, Ten,
        Dollar, Percent, Caret, Ampersand
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

        // Override ToString()
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
