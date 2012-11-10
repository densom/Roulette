namespace Roulette
{
    internal class Bet
    {
        public Bet(ColorBet color, int amount)
        {
            Color = color;
            Amount = amount;
        }

        public ColorBet Color { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1:c}", Color, Amount);
        }
    }
}