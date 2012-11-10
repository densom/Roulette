using System;

namespace Roulette
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunGame(500, 1);
            Console.Read();
        }

        private static void RunGame(int bankRoll, int minimumBet)
        {
            var rouletteTable = new RouletteTable(200);

            int betAmount = minimumBet;
            Result lastResult = null;

            for (int i = 1; i <= 100; i++)
            {
                if (lastResult != null)
                {
                    betAmount = lastResult.IsWin ? minimumBet : betAmount * 2;
                }

                if (betAmount > rouletteTable.TableLimit)
                {
                    betAmount = rouletteTable.TableLimit;
                }
                
                var bet = new Bet(ColorBet.Red, betAmount);
                Result result = rouletteTable.Bet(bet);
                lastResult = result;

                bankRoll = TallyResult(bankRoll, bet, result);
                PrintResult(bankRoll, bet, result);
            }
        }

        private static void PrintResult(int bankRoll, Bet bet, Result result)
        {
            Console.WriteLine("{2:c}\t{0}\t{1}", bet, result, bankRoll);
        }

        private static int TallyResult(int originalBankroll, Bet bet, Result result)
        {
            originalBankroll -= bet.Amount;
            originalBankroll += result.NetAmount;

            return originalBankroll;
        }
    }
}