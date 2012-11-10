namespace RouletteLogic.BettingStrategies
{
    public abstract class RouletteBettingStrategy
    {
        public abstract Bet DetermineBet(int currentBankRoll, int minimumBet, int tableLimit, Result lastResult);
    }
}