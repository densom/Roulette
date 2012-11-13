namespace RouletteLogic
{
    public static class Helper
    {
        public static int TallyResult(int originalBankroll, Bet bet, Result result)
        {
            originalBankroll -= bet.Amount;
            originalBankroll += result.NetAmount;

            return originalBankroll;
        }
    }
}