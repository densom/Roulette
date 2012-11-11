namespace RouletteLogic.BettingStrategies
{
    public class MartingaleStrategy : RouletteBettingStrategy
    {

        public override Bet DetermineBet(int currentBankRoll, int minimumBet, int tableLimit, Result lastResult)
        {
            var betAmount = minimumBet;
            
            if (lastResult != null)
            {
                betAmount = lastResult.IsWin ? minimumBet : lastResult.BetAmount * 2;
            }
            
            if (betAmount > tableLimit)
            {
                betAmount = tableLimit;
            }

            return new Bet(BetType.Red, betAmount);
        }
    }
}