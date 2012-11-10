namespace Roulette.BettingStrategies
{
    internal abstract class RouletteBettingStrategy
    {
        public abstract Bet DetermineBet(int currentBankRoll, int minimumBet, int tableLimit, Result lastResult);
    }
}