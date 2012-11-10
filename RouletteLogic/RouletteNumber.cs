namespace RouletteLogic
{
    internal class RouletteNumber
    {
        public RouletteNumber(ColorBet color, string value)
        {
            Color = color;
            Value = value;
        }

        public ColorBet Color { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", Color, Value);
        }
    }
}