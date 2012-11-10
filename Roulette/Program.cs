using System;
using System.Collections.Generic;
using RouletteLogic;
using RouletteLogic.BettingStrategies;
using RouletteLogic.Formatters;

namespace Roulette
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var results = RunGame(500, 1, 20, new MartingaleStrategy());
            PrintResult(results, new ResultTabFormatter());
            Console.Read();
        }
        

        //todo: move the RunGame logic to the RouletteLogic assembly.
        private static IEnumerable<ResultDataItem> RunGame(int bankRoll, int minimumBet, int iterations, RouletteBettingStrategy strategy)
        {
            var results = new List<ResultDataItem>(); 
            
            var rouletteTable = new RouletteTable(200);
            Result lastResult = null;

            for (int i = 1; i <= iterations; i++)
            {
                var bet = strategy.DetermineBet(bankRoll,minimumBet, rouletteTable.TableLimit, lastResult);

                Result result = rouletteTable.Bet(bet);
                lastResult = result;

                bankRoll = TallyResult(bankRoll, bet, result);
                
                results.Add(new ResultDataItem() {Bankroll = bankRoll, Bet = bet, Result = result});
            }

            return results;
        }

        private static void PrintResult(IEnumerable<ResultDataItem> items, IResultFormatter formatter)
        {
            //header
            Console.WriteLine(formatter.GetHeader());

            //detail
            foreach (var item in items)
            {
                Console.WriteLine(formatter.GetDetail(item));
            }
            
        }

        private static int TallyResult(int originalBankroll, Bet bet, Result result)
        {
            originalBankroll -= bet.Amount;
            originalBankroll += result.NetAmount;

            return originalBankroll;
        }

        
    }
}