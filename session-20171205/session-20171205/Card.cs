namespace session_20171205
{
    public class Card
    {
        public enum CardColor
        {
            Cross,
            Diamonds,
            Hearths,
            Spades
        }

        public enum CardValue
        {
            Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public CardColor Color { get; set; }
        public CardValue Value { get; set; }
    }
}
