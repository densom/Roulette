namespace RouletteLogic
{
    internal class RouletteNumber
    {
        public RouletteNumber(RouletteColors rouletteColor, string value)
        {
            RouletteColor = rouletteColor;
            Value = value;
        }

        public RouletteColors RouletteColor { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", RouletteColor, Value);
        }
    }
}