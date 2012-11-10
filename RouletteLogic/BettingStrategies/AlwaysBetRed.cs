namespace RouletteLogic.BettingStrategies
{
    internal class AlwaysBetRed : RouletteBettingStrategy
    {
        public override Bet DetermineBet(int currentBankRoll, int minimumBet, int tableLimit, Result lastResult)
        {
            return new Bet(ColorBet.Red, minimumBet);
        }
    }
}