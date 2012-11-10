using System;
using Roulette.BettingStrategies;

namespace Roulette
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RunGame(500, 1, 20, new MartingaleStrategy());
            Console.Read();
        }

        private static void RunGame(int bankRoll, int minimumBet, int iterations, RouletteBettingStrategy strategy)
        {
            var rouletteTable = new RouletteTable(200);
            Result lastResult = null;

            PrintHeader();

            for (int i = 1; i <= iterations; i++)
            {
                var bet = strategy.DetermineBet(bankRoll,minimumBet, rouletteTable.TableLimit, lastResult);

                Result result = rouletteTable.Bet(bet);
                lastResult = result;

                bankRoll = TallyResult(bankRoll, bet, result);
                
                PrintResult(bankRoll, bet, result);
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine("Bankroll\tColor\tBetAmount\tWinAmount\tIsWin");
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