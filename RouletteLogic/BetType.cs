namespace RouletteLogic
{
    public static class BetType
    {
        public static readonly BetTypeValue Red = new BetTypeValue("Red");
        public static readonly BetTypeValue Black = new BetTypeValue("Black");
        public static readonly BetTypeValue Green = new BetTypeValue("Green");
        public static readonly BetTypeValue Zero = new BetTypeValue("Zero");
        public static readonly BetTypeValue DoubleZero = new BetTypeValue("DoubleZero");
        public static readonly BetTypeValue Number17 = new BetTypeValue("Number", 17);
        public static readonly BetTypeValue Number18 = new BetTypeValue("Number", 18);
    }
}